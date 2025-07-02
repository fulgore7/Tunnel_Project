using System.Runtime.InteropServices;

namespace TunnelProject.Opc
{
    public class OpcComExceptions : COMException
    {
        /// <summary>
        /// Translation of the PLC error code to readable messages
        /// </summary>
        /// <remarks></remarks>
        public enum ExceptionCode : int
        {
            WrongTag = -1073479673                  // 0xC0040007
    ,
            ClassNotRegistered = -2147221164        // 0x80040154
    ,
            DuplicatedNameNotAllowed = -1073479668  // 0xC004000C
    ,
            UnexpectedError = -2147467259           // 0x80004005
    ,
            NoConnection = -2147220992              // 0x80040200
    ,
            FileCannotBeFound = -2147024894         // 0x80070002
        }

        public OpcComExceptions(string message, int errCode) : base(message, errCode)
        {
        }

        public static string GetOPCErrorMessage(int errCode)
        {
            ExceptionCode code = errCode;
            string msg = string.Empty;
            switch (code)
            {
                case ExceptionCode.WrongTag:
                    {
                        msg = "Tag is not defined in the PLC!!";
                        break;
                    }

                case ExceptionCode.ClassNotRegistered:
                    {
                        msg = "Class Not Registered. Maybe the OPC core components are not installed.";
                        break;
                    }

                case ExceptionCode.DuplicatedNameNotAllowed:
                    {
                        msg = "Duplicate name in the same group is not allowed.";
                        break;
                    }

                case ExceptionCode.UnexpectedError:
                    {
                        msg = "Error can not be determined.";
                        break;
                    }

                case ExceptionCode.NoConnection:
                    {
                        msg = "Advise cannot find Connection point or Unable to impersonate DCOM client";
                        break;
                    }

                case ExceptionCode.FileCannotBeFound:
                    {
                        msg = "The system cannot find the file specified.";
                        break;
                    }
            }
            return msg;
        }
    }

}
