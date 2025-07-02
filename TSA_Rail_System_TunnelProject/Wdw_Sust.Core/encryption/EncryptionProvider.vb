Imports System.Security.Cryptography
Imports System.Text
Namespace Encryption
    ''' <summary>
    ''' For more information, please check this link https://msdn.microsoft.com/en-us/library/ms172831.aspx
    ''' </summary>
    Public NotInheritable Class EncryptionProvider

#Region "Fields"
        Private ReadOnly _tripleDes As New TripleDESCryptoServiceProvider
        Private _key As String

#End Region

#Region "Methods"
        ''' <summary>
        ''' Encrypts the data.
        ''' </summary>
        ''' <param name="plaintext">The plaintext.</param>
        ''' <returns>System.String.</returns>
        Public Function EncryptData(ByVal plaintext As String) As String

            ' Convert the plaintext string to a byte array. 
            Dim plaintextBytes() As Byte = Encoding.Unicode.GetBytes(plaintext)

            ' Create the stream. 
            Dim ms As New IO.MemoryStream
            ' Create the encoder to write to the stream. 
            Dim encStream As New CryptoStream(ms, _tripleDes.CreateEncryptor(), Security.Cryptography.CryptoStreamMode.Write)

            ' Use the crypto stream to write the byte array to the stream.
            encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
            encStream.FlushFinalBlock()

            ' Convert the encrypted stream to a printable string. 
            Return System.Convert.ToBase64String(ms.ToArray)
        End Function
        ''' <summary>
        ''' Decrypts the data.
        ''' </summary>
        ''' <param name="encryptedtext">The encryptedtext.</param>
        ''' <returns>System.String.</returns>
        Public Function DecryptData(ByVal encryptedtext As String) As String

            ' Convert the encrypted text string to a byte array. 
            Dim encryptedBytes() As Byte = System.Convert.FromBase64String(encryptedtext)

            ' Create the stream.  
            Dim ms As New IO.MemoryStream
            ' Create the decoder to write to the stream.  
            Dim decStream As New CryptoStream(ms, _tripleDes.CreateDecryptor(), Security.Cryptography.CryptoStreamMode.Write)

            ' Use the crypto stream to write the byte array to the stream.
            decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
            decStream.FlushFinalBlock()

            ' Convert the plaintext stream to a string. 
            Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
        End Function

        ''' <summary>
        ''' Encrypts the data.
        ''' </summary>
        ''' <param name="textBytes">The text bytes.</param>
        ''' <returns>System.Byte().</returns>
        Public Function EncryptData(ByVal textBytes() As Byte) As Byte()

            ' Create the stream. 
            Dim ms As New IO.MemoryStream
            ' Create the encoder to write to the stream. 
            Dim encStream As New CryptoStream(ms, _tripleDes.CreateEncryptor(), Security.Cryptography.CryptoStreamMode.Write)

            ' Use the crypto stream to write the byte array to the stream.
            encStream.Write(textBytes, 0, textBytes.Length)
            encStream.FlushFinalBlock()

            ' Convert the encrypted stream to a printable string. 
            Return ms.ToArray
        End Function

        ''' <summary>
        ''' Decrypts the data.
        ''' </summary>
        ''' <param name="encryptedBytes">The encrypted bytes.</param>
        ''' <returns>System.Byte().</returns>
        Public Function DecryptData(ByVal encryptedBytes() As Byte) As Byte()

            ' Create the stream.  
            Dim ms As New IO.MemoryStream
            ' Create the decoder to write to the stream.  
            Dim decStream As New CryptoStream(ms, _tripleDes.CreateDecryptor(), Security.Cryptography.CryptoStreamMode.Write)

            ' Use the crypto stream to write the byte array to the stream.
            decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
            decStream.FlushFinalBlock()

            ' Convert the plaintext stream to a string. 
            Return ms.ToArray
        End Function
        ''' <summary>
        ''' Truncates the hash.
        ''' </summary>
        ''' <param name="key">The key.</param>
        ''' <param name="length">The length.</param>
        ''' <returns>System.Byte().</returns>
        Private Function TruncateHash(ByVal key As String, ByVal length As Integer) As Byte()
            Dim sha1 As New SHA1CryptoServiceProvider

            ' Hash the key.  
            Dim keyBytes() As Byte = Encoding.Unicode.GetBytes(key)
            Dim hash() As Byte = sha1.ComputeHash(keyBytes)

            ' Truncate or pad the hash. 
            ReDim Preserve hash(length - 1)
            Return hash
        End Function
        ''' <summary>
        ''' Tests the decoding.
        ''' </summary>
        Sub TestDecoding()
            Dim cipherText As String = My.Computer.FileSystem.ReadAllText(
            My.Computer.FileSystem.SpecialDirectories.MyDocuments &
                "\cipherText.txt")
            Dim password As String = InputBox("Enter the password:")
            Dim wrapper As New EncryptionProvider(password)

            ' DecryptData throws if the wrong password is used. 
            Try
                Dim plainText As String = wrapper.DecryptData(cipherText)
                MsgBox("The plain text is: " & plainText)
            Catch ex As Security.Cryptography.CryptographicException
                MsgBox("The data could not be decrypted with the password.")
            End Try
        End Sub
        ''' <summary>
        ''' Tests the encoding.
        ''' </summary>
        Sub TestEncoding()
            Dim plainText As String = InputBox("Enter the plain text:")
            Dim password As String = InputBox("Enter the password:")

            Dim wrapper As New EncryptionProvider(password)
            Dim cipherText As String = wrapper.EncryptData(plainText)

            MsgBox("The cipher text is: " & cipherText)
            My.Computer.FileSystem.WriteAllText(
            My.Computer.FileSystem.SpecialDirectories.MyDocuments &
            "\cipherText.txt", cipherText, False)
        End Sub

        Public Shared Function GenerateRandomKey() As String
            Dim bytes As Byte() = New Byte(7) {}
            Dim rng = New RNGCryptoServiceProvider()
            rng.GetBytes(bytes)
            Return System.Convert.ToBase64String(bytes)
        End Function

        Public Function GetKey() As String
            Return _key
        End Function
#End Region

#Region "Constructors"
        ''' <summary>
        ''' Key generated by using http://www.emvlab.org/keyshares/
        ''' </summary>
        ''' <remarks>
        ''' <see>http://msdn.microsoft.com/en-us/library/ms172831.aspx?f=255&amp;MSPPError=-2147217396</see>;
        ''' </remarks>
        Public Sub New(ByVal key As String)
            ' Initialize the crypto provider.
            _tripleDes.Key = TruncateHash(key, _tripleDes.KeySize \ 8)
            _tripleDes.IV = TruncateHash(String.Empty, _tripleDes.BlockSize \ 8)
            _key = key
        End Sub
        Public Sub New()
            Me.New(GenerateRandomKey)
        End Sub
#End Region

    End Class


End Namespace

