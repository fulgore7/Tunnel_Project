namespace TunnelProject.Opc
{
    public enum OPC_COMM_TYPE : int
    {
        OpcCommStatus = 1,
        OPCTagValueChanged = 2
    }

    public enum OpcThreadMode : int
    {
        MULTI_THREADED,
        SINGLE_THREADED
    }

    public enum CipMedia : sbyte
    {
        Ethernet = 18,
        Backplane = 1
    }
}
