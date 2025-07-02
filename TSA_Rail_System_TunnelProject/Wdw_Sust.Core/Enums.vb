Imports System.ComponentModel

Public Module Enums
    Public Enum EndpointStatus
        Connected = 1
        NotFound = 2
        UnknownException = 3
    End Enum

    ''' <summary>
    ''' MouseHandlingMode: None, Panning, Zooming
    ''' </summary>
    Public Enum MouseHandlingMode
        None
        Panning
        Zooming
    End Enum

    ''' <summary>
    ''' WcfBindingType: Tcp, Http
    ''' </summary>
    Public Enum WcfBindingType
        Tcp
        Http
    End Enum

    ''' <summary>
    ''' IOType: OUTPUT, INPUT
    ''' </summary>
    Public Enum IOType As Integer
        OUTPUT = 0
        INPUT = 1
    End Enum

    Public Enum PlantZone As Integer
        SOILED = 1
        CLEAN = 2
    End Enum

    ''' <summary>
    ''' SerialPortBaudRate: Baud4800, Baud9600, Baud19200, Baud38400, Baud57600, Baud115200, Buad230400
    ''' </summary>
    Public Enum SerialPortBaudRate As Integer
        <Description("4800")>
        Baud4800 = 4800
        <Description("9600")>
        Baud9600 = 9600
        <Description("19200")>
        Baud19200 = 19200
        <Description("38400")>
        Baud38400 = 38400
        <Description("57600")>
        Baud57600 = 57600
        <Description("115200")>
        Baud115200 = 115200
        <Description("230400")>
        Buad230400 = 230400
    End Enum
    Public Enum ArrayStartWithIndex As Integer
        ZERO = 0
        ONE = 1
    End Enum
    Public Enum RunTimeStatus
        Started
        Stopped
        Paused
    End Enum

    Public Enum Trending
        Unknown
        Up
        Down
        Flat
    End Enum

    Public Enum DataType As Integer
        Numeric
        Text
    End Enum
    Public Enum TimeUnit
        MicroSecond
        MilliSecond
        Second
        Minute
    End Enum
    Public Enum ServiceStatus As Integer
        Unknown
        StartPending
        Started
        StopPending
        Stopped
    End Enum
    ''' <summary>
    ''' This is to determine which mode the program is in
    ''' Maintenance mode has the following restrictions
    ''' 1.) Do not record edits from system operators.
    ''' 2.) Only used when the default database is not reachable.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum ProgramMode As Integer
        <Description("Unknown")>
        UNKNOWN = 0
        <Description("Production Mode")>
        PRODUCTION = 1
        <Description("Maintenance Mode")>
        MAINTENANCE = 2
        <Description("Development Mode")>
        DEVELOPMENT = 3
        <Description("Fail Over Auto")>
        FAIL_OVER_AUTO = 4
        <Description("Fail Over Manual")>
        FAIL_OVER_MANUAL = 5
        <Description("Test")>
        TEST = 6
    End Enum

    Public Enum Shift As Integer
        <Description("Unknown")>
        UNKNOWN = 0
        <Description("First Shift")>
        FIRST_SHIFT = 1
        <Description("Second Shift")>
        SECOND_SHIFT = 2
        <Description("Third Shift")>
        THIRD_SHIFT = 3
        <Description("All Shift")>
        ALL_SHIFT = 4
        <Description("Non Shift")>
        NON_SHIFT = 99
    End Enum
    Public Enum FormMode As Integer
        <Description("Unknown")>
        UNKNOWN
        <Description("Edit Mode")>
        EDIT
        <Description("Normal Mode")>
        NORMAL
        <Description("Edit Mode")>
        NORMAL_WITH_EDIT_ONLY
        NORMAL_WITH_DELETE
        <Description("Add Mode")>
        ADD
        DELETE
        <Description("Readonly Mode")>
        READ_ONLY
        NOT_CLICKABLE
    End Enum
    Public Enum Frequency As Integer
        UNKNOWN
        MINUTELY
        HOURLY
        DAILY
        WEEKLY
        MONTHLY
        IRREGULARLY
    End Enum
    Public Enum SortDirection As Integer
        ASC
        DESC
    End Enum

    Public Enum FormType As Integer
        NO_FORM
        <Description("TSA_Rail_System")>
        TSA_CLASSIFIED_LOADING
        <Description("TSA_Rail_System")>
        TSA_CLASSIFIED_STORAGE
        <Description("TSA_Rail_System")>
        TSA_CLASSIFIED_DISCHARGERS
        <Description("TSA_Rail_System")>
        TSA_WASHDECK
        <Description("TSA_Rail_System")>
        TSA_CLEANWORK_RAIL
        <Description("TSA_Rail_System")>
        TSA_CLEANWORK_PRODUCTIVITY
        <Description("ASA_Rail_System")>
        ASA_RAIL_SYSTEM
        <Description("ASA_Rail_System")>
        ASA_WASHER_LOADING
    End Enum

End Module

