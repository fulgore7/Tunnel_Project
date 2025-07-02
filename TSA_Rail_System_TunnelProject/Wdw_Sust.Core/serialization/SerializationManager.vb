' ***********************************************************************
' Assembly         : Wdw_Sust.Core
' Author           : yeunc009
' Created          : 01-20-2017
'
' Last Modified By : yeunc009
' Last Modified On : 06-13-2017
' ***********************************************************************
' <copyright file="SerializationManager.vb" company="TWDC">
'     Copyright © Microsoft 2016
' </copyright>
' <summary></summary>
' ***********************************************************************
Imports System.Runtime.Serialization
Imports System.IO
Imports System.Xml.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text

Imports Wdw_Sust.Core.Encryption

Namespace Serialization
    ''' <summary>
    ''' Class SerializationManager. This class is used to manage all class object serialized into different formats.
    ''' </summary>
    Public Class SerializationManager

        ''' <summary>
        ''' Serializes the data.
        ''' </summary>
        ''' <param name="data">The data.</param>
        ''' <returns>System.Byte().</returns>
        Public Shared Function SerializeData(ByVal data As Object) As Byte()
            Using objMemStream As New MemoryStream()
                Dim objBinaryFormatter As New BinaryFormatter(Nothing, New StreamingContext(StreamingContextStates.Clone))
                objBinaryFormatter.Serialize(objMemStream, data)
                objMemStream.Seek(0, SeekOrigin.Begin)
                Return objMemStream.ToArray
            End Using
        End Function

        ''' <summary>
        ''' Deserializes the data.
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="data">The data.</param>
        ''' <returns>T.</returns>
        Public Shared Function DeserializeData(Of T)(ByVal data() As Byte) As T
            Dim returnData As T = DirectCast(DeserializeData(data), T)
            Return returnData
        End Function

        ''' <summary>
        ''' Deserializes the data.
        ''' </summary>
        ''' <param name="data">The data.</param>
        ''' <returns>System.Object.</returns>
        Public Shared Function DeserializeData(ByVal data() As Byte) As Object
            Using objMemStream As New MemoryStream(data)
                Dim objBinaryFormatter As New BinaryFormatter(Nothing, New StreamingContext(StreamingContextStates.Clone))
                Return objBinaryFormatter.Deserialize(objMemStream)
            End Using
        End Function

        ''' <summary>
        ''' Serializes to file.
        ''' </summary>
        ''' <param name="path">The path.</param>
        ''' <param name="obj">The object.</param>
        Public Shared Sub SerializeToFile(ByVal path As String, ByVal obj As Object)
            Using fs As New FileStream(path, FileMode.Create, FileAccess.Write)
                Dim bytes As Byte() = SerializeData(obj)
                fs.Write(bytes, 0, bytes.Length)
            End Using
        End Sub

        ''' <summary>
        ''' Deserializes from binary file.
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="path">The path.</param>
        ''' <returns>T.</returns>
        Public Shared Function DeserializeFromBinaryFile(Of T)(ByVal path As String) As T
            Dim length As Integer
            Try
                If File.Exists(path) Then
                    Using fs As New FileStream(path, FileMode.Open, FileAccess.Read)
                        length = fs.Length
                        Dim bytes(length - 1) As Byte
                        fs.Read(bytes, 0, length)
                        Return DeserializeData(Of T)(bytes)
                    End Using
                End If
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' Deserializes from XML object string.
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="objString">The object string.</param>
        ''' <returns>T.</returns>
        Public Shared Function DeserializeFromXMLObjectString(Of T)(ByVal objString As String) As T
            Try
                Dim serializer As New XmlSerializer(GetType(T))
                Using stream As New MemoryStream(Encoding.UTF8.GetBytes(objString))
                    Return CType(serializer.Deserialize(stream), T)
                End Using
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' Serializes to XML object string.
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="obj">The object.</param>
        ''' <returns>System.String.</returns>
        Public Shared Function SerializeToXMLObjectString(Of T)(ByVal obj As T) As String
            Try
                Dim serializer As New XmlSerializer(GetType(T))
                Using textWriter As New StringWriter()
                    serializer.Serialize(textWriter, obj)
                    Return textWriter.ToString
                End Using
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' Deserializes from XML file.
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="path">The path.</param>
        ''' <returns>T.</returns>
        Public Shared Function DeserializeFromXmlFile(Of T)(ByVal path As String) As T
            If File.Exists(path) Then
                Try
                    Dim serializer As New XmlSerializer(GetType(T))
                    Using reader As New StreamReader(path)
                        Return CType(serializer.Deserialize(reader), T)
                    End Using
                Catch ex As Exception
                    Return Nothing
                End Try
            Else
                Return Nothing
            End If
        End Function

        ''' <summary>
        ''' Serializes to XML.
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="path">The path.</param>
        ''' <param name="obj">The object.</param>
        Public Shared Sub SerializeToXML(Of T)(ByVal path As String, ByVal obj As T)
            SerializeToXML(path, obj, FileMode.Append)
        End Sub

        ''' <summary>
        ''' Serializes to XML.
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="path">The path.</param>
        ''' <param name="obj">The object.</param>
        ''' <param name="fileMode">The file mode.</param>
        Public Shared Sub SerializeToXML(Of T)(ByVal path As String, ByVal obj As T, ByVal fileMode As FileMode)
            Using objMemStream As New MemoryStream()
                objMemStream.Seek(0, SeekOrigin.Begin)
                Using fs As New FileStream(path, fileMode, FileAccess.Write)
                    Try
                        Dim x As New XmlSerializer(GetType(T))
                        x.Serialize(objMemStream, obj)
                        objMemStream.Seek(0, SeekOrigin.Begin)
                        fs.Write(objMemStream.ToArray, 0, objMemStream.Length)
                    Catch ex As Exception
                    Finally
                        fs.Close()
                    End Try
                End Using
            End Using
        End Sub

        ''' <summary>
        ''' Deserializes from encrypted XML file with key.
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="path">The path.</param>
        ''' <returns>T.</returns>
        Public Shared Function DeserializeFromEncryptedXmlFileWithKey(Of T)(ByVal path As String) As T
            If File.Exists(path) Then
                Try
                    Dim serializer As New XmlSerializer(GetType(T))
                    Using br As New BinaryReader(New MemoryStream(File.ReadAllBytes(path)))
                        Dim keyLength = br.ReadInt32()
                        Dim key = System.Convert.ToBase64String(br.ReadBytes(keyLength))
                        Dim databuffer = br.ReadBytes(br.ReadInt32())
                        Dim decryptor = New EncryptionProvider(key)
                        Dim decryptData As Byte() = decryptor.DecryptData(databuffer)
                        Return CType(serializer.Deserialize(New MemoryStream(decryptData)), T)
                    End Using
                Catch ex As Exception
                    Return Nothing
                End Try
            Else
                Return Nothing
            End If
        End Function

        ''' <summary>
        ''' Serializes to encrypted object with key
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="key">The key.</param>
        ''' <param name="obj">The object.</param>
        ''' <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        Public Shared Function SerializeToEncryptedObjectWithKey(Of T)(ByVal key As String, ByVal obj As T) As Byte()
            Dim output As Byte() = Nothing

            Try
                Using objMemStream As New MemoryStream()
                    Using stream As New MemoryStream()
                        objMemStream.Seek(0, SeekOrigin.Begin)
                        Try
                            Dim x As New BinaryFormatter
                            x.Serialize(objMemStream, obj)
                            Dim encryptor = New EncryptionProvider(key)
                            Dim encryptedData = encryptor.EncryptData(objMemStream.ToArray)
                            Dim y = System.Convert.FromBase64String(key)
                            stream.Write(BitConverter.GetBytes(y.Length), 0, Runtime.InteropServices.Marshal.SizeOf(GetType(Integer)))
                            stream.Write(y, 0, y.Length)
                            stream.Write(BitConverter.GetBytes(encryptedData.Length), 0, Runtime.InteropServices.Marshal.SizeOf(GetType(Integer)))
                            stream.Write(encryptedData, 0, encryptedData.Length)
                            output = stream.ToArray()
                        Catch ex As Exception
                        Finally
                            objMemStream.Close()
                        End Try
                    End Using

                End Using
            Catch ex As Exception
                Return Nothing
            End Try

            Return output
        End Function
        ''' <summary>
        ''' Deserializes from encrypted XML file with key.
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="encryptedData">The path.</param>
        ''' <returns>T.</returns>
        Public Shared Function DeserializeFromEncryptedObjectWithKey(Of T)(ByVal encryptedData As Byte()) As T

            Try
                Dim serializer As New BinaryFormatter
                Using br As New BinaryReader(New MemoryStream(encryptedData))
                    Dim keyLength = br.ReadInt32()
                    Dim key = System.Convert.ToBase64String(br.ReadBytes(keyLength))
                    Dim databuffer = br.ReadBytes(br.ReadInt32())
                    Dim decryptor = New EncryptionProvider(key)
                    Dim decryptData As Byte() = decryptor.DecryptData(databuffer)
                    Return serializer.Deserialize(New MemoryStream(decryptData))
                End Using
            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        ''' <summary>
        ''' Serializes to encrypted XML with key.
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="key">The key.</param>
        ''' <param name="path">The path.</param>
        ''' <param name="obj">The object.</param>
        ''' <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        Public Shared Function SerializeToEncryptedXmlWithKey(Of T)(ByVal key As String, ByVal path As String, ByVal obj As T) As Boolean
            Return SerializeToEncryptedXmlWithKey(key, path, obj, FileMode.Create)
        End Function

        ''' <summary>
        ''' Serializes to encrypted XML with key.
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="key">The key.</param>
        ''' <param name="path">The path.</param>
        ''' <param name="obj">The object.</param>
        ''' <param name="fileMode">The file mode.</param>
        ''' <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        Public Shared Function SerializeToEncryptedXmlWithKey(Of T)(ByVal key As String, ByVal path As String, ByVal obj As T, ByVal fileMode As FileMode) As Boolean
            Try
                Using objMemStream As New MemoryStream()
                    objMemStream.Seek(0, SeekOrigin.Begin)
                    Using fs As New FileStream(path, fileMode, FileAccess.Write)
                        Try
                            Dim x As New XmlSerializer(GetType(T))
                            x.Serialize(objMemStream, obj)
                            Dim encryptor = New EncryptionProvider(key)
                            Dim encryptedData = encryptor.EncryptData(objMemStream.ToArray)
                            Dim y = System.Convert.FromBase64String(key)
                            fs.Write(BitConverter.GetBytes(y.Length), 0, Runtime.InteropServices.Marshal.SizeOf(GetType(Integer)))
                            fs.Write(y, 0, y.Length)
                            fs.Write(BitConverter.GetBytes(encryptedData.Length), 0, Runtime.InteropServices.Marshal.SizeOf(GetType(Integer)))
                            fs.Write(encryptedData, 0, encryptedData.Length)
                        Catch ex As Exception
                        Finally
                            fs.Close()
                        End Try
                    End Using
                End Using
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function
        ''' <summary>
        ''' Determines whether the specified object is serializable.
        ''' </summary>
        ''' <param name="obj">The object.</param>
        ''' <returns><c>true</c> if the specified object is serializable; otherwise, <c>false</c>.</returns>
        Public Shared Function IsSerializable(obj As Object) As Boolean
            Return (TypeOf obj Is ISerializable) OrElse (Attribute.IsDefined(obj.GetType, GetType(SerializableAttribute)))
        End Function
    End Class
End Namespace




