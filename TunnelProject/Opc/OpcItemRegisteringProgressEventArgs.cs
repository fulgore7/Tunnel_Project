namespace TunnelProject.Opc
{
        public class OpcItemRegisteringProgressEventArgs : System.EventArgs
        {
            public int Progress { get; }

            public OpcItemRegisteringProgressEventArgs(int progress)
            {
                Progress = progress;
            }
        }
}
