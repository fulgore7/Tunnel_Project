Imports System.ComponentModel

Public Module Enums

    Public Enum PerformanceValueType
        PoundsSorted = 1
        PoundsDroppedIntoWasher = 2
        PoundsWashed = 3
        PoundsDroppedAtFlatwork = 4
    End Enum

    Public Enum InformationSource As Integer
        Unknown
        Wcf
        Database
    End Enum

    Public Enum AlarmWorkflowSystemDiagnosticsGroup As Integer
        SORTING = 1
        PRESS = 2
    End Enum

    Public Enum LintDataCollectionSessionChangeReason
        UNKNOWN_REASON = 0
        MACHINE_STOPPED = 2
        END_OF_HOUR = 6
        UNPRODUCVTIVE_RUN = 10
        PRODUCTIVE_RUN = 18
        MACHINE_FAULTED = 19
        MACHINE_MAINTENANCE_BY_PRODUCTION = 20
        MACHINE_MAINTENANCE_BY_ENGINEERING = 21
        MACHINE_MINUTELY_UPDATE = 22
    End Enum

    Public Enum ConnectionStringName As Integer
        LintProductionConnection
        LintStagingConnection
        LintDevelopmentConnection
        LintFailOverConnection
        WdwLaundryAutomationProd
        TextilesProd
        GusProductionConnection
        GusFailOverConnection
        FloCockpitConnection
    End Enum

    ''' <summary>
    ''' Default LINT Access Levels. This is used to map the default settings
    ''' for different roles when the user was first assigned in the system.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum DefaultLINTAccessLevel As Integer

        'Default
        NO_ACCESS = 0

        READ_ONLY = 1
        ENGINEER_MANAGER = 475301
        OPERATIONS_MANAGER = 213221
        PLANT_MANAGER = 475365
        PRODUCTION_MANAGER = 475333
        SYSTEM_ADMINISTRATOR = 524287
        SYSTEM_SUPPORT = 482725
        AREA_SUPERVISOR = 262277

        'TSA
        TSA_AREA_SUPERVISOR = AREA_SUPERVISOR

        TSA_ENGINEER_CRAFT_SUPPORT = READ_ONLY
        TSA_ENGINEER_FOREMAN = READ_ONLY
        TSA_ENGINEER_LSM = READ_ONLY
        TSA_ENGINEER_LSM_JR = READ_ONLY
        TSA_ENGINEER_MANAGER = ENGINEER_MANAGER
        TSA_ENGINEER_MANAGER_TEAM_LEADER = ENGINEER_MANAGER
        TSA_OPERATIONS_MANAGER = OPERATIONS_MANAGER
        TSA_OUTSIDE_VENDOR = NO_ACCESS
        TSA_PLANT_MANAGER = PLANT_MANAGER
        TSA_PRODUCTION_MANAGER = PRODUCTION_MANAGER
        TSA_PRODUCTION_OPERATOR = NO_ACCESS
        TSA_SYSTEM_ADMINISTRATOR = SYSTEM_ADMINISTRATOR
        TSA_SYSTEM_OPERATOR = READ_ONLY
        TSA_SYSTEM_OPERATOR_SR = READ_ONLY
        TSA_SYSTEM_SUPPORT = SYSTEM_SUPPORT
        TSA_UNASSIGNED = NO_ACCESS

        'NSA
        NSA_AREA_SUPERVISOR = AREA_SUPERVISOR

        NSA_ENGINEER_CRAFT_SUPPORT = READ_ONLY
        NSA_ENGINEER_FOREMAN = READ_ONLY
        NSA_ENGINEER_LSM = READ_ONLY
        NSA_ENGINEER_LSM_JR = READ_ONLY
        NSA_ENGINEER_MANAGER = ENGINEER_MANAGER
        NSA_ENGINEER_MANAGER_TEAM_LEADER = ENGINEER_MANAGER
        NSA_OPERATIONS_MANAGER = OPERATIONS_MANAGER
        NSA_OUTSIDE_VENDOR = NO_ACCESS
        NSA_PLANT_MANAGER = PLANT_MANAGER
        NSA_PRODUCTION_MANAGER = PRODUCTION_MANAGER
        NSA_PRODUCTION_OPERATOR = NO_ACCESS
        NSA_SYSTEM_ADMINISTRATOR = SYSTEM_ADMINISTRATOR
        NSA_SYSTEM_OPERATOR = READ_ONLY
        NSA_SYSTEM_OPERATOR_SR = READ_ONLY
        NSA_SYSTEM_SUPPORT = SYSTEM_SUPPORT
        NSA_UNASSIGNED = NO_ACCESS

        'ASA
        ASA_AREA_SUPERVISOR = AREA_SUPERVISOR

        ASA_ENGINEER_CRAFT_SUPPORT = READ_ONLY
        ASA_ENGINEER_FOREMAN = READ_ONLY
        ASA_ENGINEER_LSM = READ_ONLY
        ASA_ENGINEER_LSM_JR = READ_ONLY
        ASA_ENGINEER_MANAGER = ENGINEER_MANAGER
        ASA_ENGINEER_MANAGER_TEAM_LEADER = ENGINEER_MANAGER
        ASA_OPERATIONS_MANAGER = OPERATIONS_MANAGER
        ASA_OUTSIDE_VENDOR = NO_ACCESS
        ASA_PLANT_MANAGER = PLANT_MANAGER
        ASA_PRODUCTION_MANAGER = PRODUCTION_MANAGER
        ASA_PRODUCTION_OPERATOR = NO_ACCESS
        ASA_SYSTEM_ADMINISTRATOR = SYSTEM_ADMINISTRATOR
        ASA_SYSTEM_OPERATOR = READ_ONLY
        ASA_SYSTEM_OPERATOR_SR = READ_ONLY
        ASA_SYSTEM_SUPPORT = SYSTEM_SUPPORT
        ASA_UNASSIGNED = NO_ACCESS

        'Unknown
        UNKNOWN_AREA_SUPERVISOR = NO_ACCESS

        UNKNOWN_ENGINEER_CRAFT_SUPPORT = NO_ACCESS
        UNKNOWN_ENGINEER_FOREMAN = NO_ACCESS
        UNKNOWN_ENGINEER_LSM = NO_ACCESS
        UNKNOWN_ENGINEER_LSM_JR = NO_ACCESS
        UNKNOWN_ENGINEER_MANAGER = NO_ACCESS
        UNKNOWN_ENGINEER_MANAGER_TEAM_LEADER = ENGINEER_MANAGER
        UNKNOWN_OPERATIONS_MANAGER = NO_ACCESS
        UNKNOWN_OUTSIDE_VENDOR = NO_ACCESS
        UNKNOWN_PLANT_MANAGER = NO_ACCESS
        UNKNOWN_PRODUCTION_MANAGER = NO_ACCESS
        UNKNOWN_PRODUCTION_OPERATOR = NO_ACCESS
        UNKNOWN_SYSTEM_ADMINISTRATOR = NO_ACCESS
        UNKNOWN_SYSTEM_OPERATOR = NO_ACCESS
        UNKNOWN_SYSTEM_OPERATOR_SR = NO_ACCESS
        UNKNOWN_SYSTEM_SUPPORT = NO_ACCESS
        UNKNOWN_UNASSIGNED = NO_ACCESS

    End Enum

    ''' <summary>
    ''' Card Assignment Reason:
    ''' 1 = Card assigned to the Cast Member the first time
    ''' 2 = Card reassigned due to card lost
    ''' 3 = Card reassigned due to card malfunction - no penalty for this type of re-assignment
    ''' 4 = Card Assigned to Existing Cast Member for the First Time
    ''' 5 = Change cast member status - no penalty for this type of re-assignment
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum CardAssignmentReason As Integer
        FIRST_TIME_NEW_CM = 1
        CARD_LOST = 2
        MALFUNCTION = 3
        FIRST_TIME_EXISTING_CM = 4
        CHANGE_OF_STATUS = 5
    End Enum

    Public Enum LintActionState As Integer
        UNKNOWN = 0
        REQUESTING_TO_CHANGE_STATE = 1
        STATE_CHANGE_COMPLETED = 2
        NORMAL = 3
    End Enum

    Public Enum BagDestinationType As Integer
        DROP_DESTINATION
        STORAGE_DESTINATION
    End Enum

    Public Enum ChooseValue As Integer
        UNKNOWN = 0
        DROP_DESTINATION = 1
        STORAGE_DESTINATION = 2
        SORTING_STATION = 3
        CLEANWORK_RECIRCULATION = 4
        CLASSIFIED_RECIRCULATION = 5
        ALLOCATED_WASHER = 6
    End Enum

    ''' <summary>
    ''' This list is mapped to the database table "LINT_software.LINT_Reasoning_Lookup""
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum LintReasoning As Integer

        <Description("Mixed Load")>
        MIXED_LOAD = 1

        <Description("Wrong Product")>
        WRONG_PRODUCT = 2

        <Description("Wet Load")>
        WET_LOAD = 3

        <Description("Burn Load")>
        BURNED_LOAD = 4

        <Description("Dry Load")>
        DRY_LOAD = 5

        <Description("Chemical Related")>
        CHEMICAL_RELATED = 6

        <Description("Tangled Load")>
        TANGLED_LOAD = 7

    End Enum

    Public Enum LintRundownZone As Integer
        UNKNOWN = 0
        CLASSIFIED_ONGOING = 1
        CLASSIFIED_OFFGOING = 2
        CLASSIFIED_WHOLE = 3
        CLEANWORK_ONGOING = 4
        CLEANWORK_OFFGOING = 5
        CLEANWORK_WHOLE = 6
        WASHDECK_ONGOING = 7
        WASHDECK_OFFGOING = 8
        WASHDECK_WHOLE = 9
    End Enum

    Public Enum BagDrawingMode As Integer

        <Description("2 Dimension")>
        TWO_DIMENSION = 1

        <Description("3 Dim. Fade-in")>
        THREE_DIMENSION_FADE_IN = 2

        <Description("3 Dim. Fade-out")>
        THREE_DIMENSION_FADE_OUT = 3

    End Enum

    Public Enum PictureShown
        UNDETERMINED
        TRUE_PICTURE
        FALSE_PICTURE
    End Enum

    Public Interface IHavePlant
        Property Plant As Plant
    End Interface

    ''' <summary>
    ''' This enum series has to match with the table "LINT_software.LINT_System_Origin_Lookup" in the database
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum LintSystemOrigin As Integer

        <Description("Unknown")>
        UNKNOWN = 0

        <Description("Classified System")>
        CLASSIFIED_SYSTEM = 1

        <Description("Cleanwork System")>
        CLEANWORK_SYSTEM = 2

        <Description("Futurail Admin System")>
        FUTURAIL_ADMINISTRATION_SYSTEM = 3

        <Description("LavaTec System")>
        LAVATEC_SYSTEM = 4

        <Description("Ecolab")>
        ECOLAB_SYSTEM = 5

        <Description("Productivity System")>
        PRODUCTIVITY_SYSTEM = 6

        <Description("Plant System")>
        PLANT_SYSTEM = 7

        <Description("Flatwork System")>
        FLATWORK_SYSTEM = 8

        <Description("Finishing")>
        FINISHING = 9

    End Enum

    ''' <summary>
    ''' This enum series has to match with the table "LINT_software.LINT_Machine_Type_Lookup" in the database
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum LintMachineType As Integer
        UNKNOWN = 0
        TOWEL_FOLDER = 1
        FEEDER = 2
        IRONER = 3
        FOLDER = 4
        STACKER = 5
        IRONER_SCANNER = 6
        SORTING_STATION = 7
    End Enum

    ''' <summary>
    ''' This enum series has to match with the table "LINT_software.LINT_Department_Lookup" in the database
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum LintDepartments As Integer
        UNKNOWN_DEPARTMENT = 0
        PC = 100
        SH = 101
        TF = 102
        CLASSIFIED_SORTING = 103
        HAND_FOLD = 104
        CLASSIFIED_STORAGE = 106
        WASH_DECK = 107
        CLASSIFIED_EMPTY_BAG = 108
        CLEANWORK_LOADING = 110
        CLEANWORK_STORAGE = 111
        CLEANWORK_EMPTY_BAG = 112
        CLASSIFIED_SYSTEM = 113
        CLEANWORK_SYSTEM = 114
        CART_DUMP = 115
        NSA_CLASSIFIED_SORTING = 203
        NSA_HAND_FOLD = 204
        NSA_CLASSIFIED_STORAGE = 206
        NSA_WASH_DECK = 207
        NSA_CLASSIFIED_EMPTY_BAG = 208
        NSA_CLEANWORK_STORAGE = 211
        NSA_CLEANWORK_EMPTY_BAG = 212
        HANGING = 216
        PRESSLINE = 217
        FINISHING = 218
        SHIPPING_STORAGE = 219
        MARRYING_STATIONS = 220
        QUALITY_CONTROL = 221
        WASH_DECK_EMPTY_BAG = 222
        STEAM_TUNNEL = 223
        FLATWORK = 301
        MASS_TOWEL = 302
    End Enum

    ''' <summary>
    ''' This enum series has to match with the table "LINT_software.LINT_System_Origin_Lookup" in the database
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum LintSystemOrigins As Integer

        <Description("Unknown")>
        UNKNOWN = 0

        <Description("Classified System")>
        CLASSIFIED_SYSTEM = 1

        <Description("Cleanwork System")>
        CLEANWORK_SYSTEM = 2

        <Description("Futurail Admin System")>
        FUTURAIL_ADMINISTRATION_SYSTEM = 3

        <Description("LavaTec System")>
        LAVATEC_SYSTEM = 4

        <Description("Ecolab")>
        ECOLAB_SYSTEM = 5

        <Description("Productivity System")>
        PRODUCTIVITY_SYSTEM = 6

        <Description("Plant System")>
        PLANT_SYSTEM = 7

        <Description("Flatwork System")>
        FLATWORK_SYSTEM = 8

        <Description("Finishing")>
        FINISHING = 9

    End Enum

    Public Enum PLC_System
        Classified_PLC
        Cleanwork_PLC
    End Enum

    ''' <summary>
    ''' This enum series is mapped to database table "LINT_software.LINT_Zone_Lookup"
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum LintZone As Integer

        <Description("Unknown")>
        UNKNOWN = 0

        <Description("Cart Dumper")>
        CART_DUMPER = 1

        <Description("Sorting")>
        SORTING = 2

        <Description("Classified Ongoing Buffer")>
        CLASSIFIED_ONGOING_BUFFER = 3

        <Description("Classified Storage")>
        CLASSIFIED_STORAGE = 4

        <Description("classified Off-going Buffer")>
        CLASSIFIED_OFFGOING_BUFFER = 5

        <Description("Classified Storage")>
        CLASSIFIED_DISCHARGER = 6

        <Description("Tunnel Washer")>
        TUNNEL_WASHER = 7

        <Description("Washer Extractor")>
        WASHER_EXTRACTOR = 8

        <Description("Classified Empty Bag Return")>
        CLASSIFIED_EMPTY_BAG_RETURN = 9

        <Description("Cleanwork Loading")>
        CLEANWORK_LOADING = 10

        <Description("Cleanwork Ongoing Buffer")>
        CLEANWORK_ONGOING_BUFFER = 11

        <Description("Cleanwork Storage")>
        CLEANWORK_STORAGE = 12

        <Description("Cleanwork Flatwork Machine")>
        CLEANWORK_FLATWORK_MACHINE = 13

        <Description("Cleanwork Old Towel Fold")>
        CLEANWORK_OLD_TOWEL_FOLD = 14

        <Description("Cleanwork New Towel Fold")>
        CLEANWORK_NEW_TOWEL_FOLD = 15

        <Description("Cleanwork Hand Fold")>
        CLEANWORK_HAND_FOLD = 16

        <Description("Cleanwork Off-going Buffer")>
        CLEANWORK_OFFGOING_BUFFER = 17

        <Description("Cleanwork Empty Bag Return")>
        CLEANWORK_EMPTY_BAG_RETURN = 18

        <Description("Mechanical Room")>
        MECHANICAL_ROOM = 19

        <Description("Computer Room")>
        COMPUTER_ROOM = 20

        <Description("Classified PLC")>
        CLASSIFIED_PLC = 21

        <Description("Cleanwork PLC")>
        CLEANWORK_PLC = 22

        <Description("Productivity PLC")>
        PRODUCTIVITY_PLC = 23

        <Description("Cart Washer")>
        CART_WASHER = 24

        <Description("Hanging Workstation")>
        HANGING_WORKSTATIONS = 25

        <Description("Pressline Workstation")>
        PRESSLINE_WORKSTATIONS = 26

        <Description("Cleanwork Finishing")>
        CLEANWORK_FINISHING = 27

        <Description("Hanging Ongoing Discharger")>
        HANGING_ONGOING_DISCHARGER = 28

        <Description("Hanging Ongoing Buffer")>
        HANGING_ONGOING_BUFFER = 29

        <Description("Cleanwork Flatwork Discharger")>
        CLEANWORK_FLATWORK_DISCHARGER = 30

        <Description("Washdeck PLC")>
        WASHDECK_PLC = 31

        <Description("Tunnel Press")>
        TUNNEL_PRESS = 32

        <Description("Cleanwork Towel Fold Discharger")>
        CLEANWORK_TOWEL_FOLD_DISCHARGER = 33

    End Enum

    ''' <summary>
    ''' This list is mapped to the database table "LINT_software.LINT_Action_Lookup""
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum LintAction As Integer
        UNKNOWN_ACTION = 0
        ADD_BAG = 1
        EDIT_BAG = 2
        DELETE_BAG = 3
        SEQUENCE_EDIT = 4
        WASHER_LOADING = 5
        STEAM_TUNNEL_SETTING_EDIT = 6
        RUN_DOWN_SYSTEM = 7
        RUN_UP_SYSTEM = 8
        WEIGHT_STATION_CATEGORY_EDIT = 9
        SHORT_TRIP_SET = 10
        SHORT_TRIP_RESET = 11
        CLEANWORK_CALL_OFF_EDIT = 12
        CLASSIFIED_CALL_OFF_EDIT = 13
        EXPRESS_PRODUCT_CHANGE = 14
        BAG_ISSUE_REPORTED = 15
        WEIGHT_STATION_CALIBRATION_STARTED = 16
        WEIGHT_STATION_CALIBRATION_ENDED = 17
        WEIGHT_STATION_CALIBRATION_CANCELED = 18
        CHANGE_CLEANWORK_CALL_OFF = 19
        CALL_OFF_ENABLE = 20
        CALL_OFF_DISABLE = 21
        WEIGHT_STATION_CALIBRATION_COMPLETED = 22
        RESET_PRODUCTION_NUMBER = 23
        TSA_CATEGORY_WORKFLOW_PARAMETER_CHANGED = 24
        CHANGE_CATEGORY_RELEASE_WEIGHT = 25
        BLOCK_STORAGE_RAIL = 26
        UNBLOCK_STORAGE_RAIL = 27
        ENABLE_LOGIN_VALIDATION = 28
        DISABLE_LOGIN_VALIDATION = 29
        SWITCH_GATE_ACTIVATE = 30
        SWITCH_GATE_DEACTIVATE = 31
    End Enum

    Public Enum WorkStations As Integer

        <Description("Unknown Workstation")>
        UNKNOWN = 0

        <Description("LINT Application Server")>
        LINT_APPLICATION_SERVER = 1

        <Description("TSA Data Collection")>
        TSA_DATA_COLLECTION_PC = 2

        <Description("TSA Washdeck Control PC - Soiled Side")>
        TSA_WASHDECK_CONTROL_PC_1 = 3

        <Description("TSA Sorting Control PC")>
        TSA_SORTING_CONTROL_PC = 4

        <Description("TSA Cleanwork Control PC")>
        TSA_CLEANWORK_CONTROL_PC = 5

        <Description("TSA Coaches Control PC")>
        TSA_COACHES_PC = 6

        <Description("NSA Data Collection PC")>
        NSA_DATA_COLLECTION_PC = 7

        <Description("NSA Sorting Control PC")>
        NSA_SORTING_CONTROL_PC = 8

        <Description("NSA Washdeck Control PC")>
        NSA_WASHDECK_CONTROL_PC = 9

        <Description("NSA Hanging Control PC")>
        NSA_HANGING_CONTROL_PC = 10

        <Description("NSA Coaches PC")>
        NSA_COACHES_PC = 11

        <Description("ASA Data Collection PC")>
        ASA_DATA_COLLECTION_PC = 12

        <Description("ASA Sorting Control PC")>
        ASA_SORTING_CONTROL_PC = 13

        <Description("ASA Cleanwork Control PC")>
        ASA_CLEANWORK_CONTROL_PC = 14

        <Description("ASA Flatwork Productivity Display 1")>
        ASA_FLATWORK_PRODUCTIVITY_DISPLAY_1_PC = 15

        <Description("ASA Flatwork Productivity Display 2")>
        ASA_FLATWORK_PRODUCTIVITY_DISPLAY_2_PC = 16

        <Description("ASA Flatwork Productivity Display 3")>
        ASA_FLATWORK_PRODUCTIVITY_DISPLAY_3_PC = 17

        <Description("ASA Mass Towel Display")>
        ASA_MASS_TOWEL_DISPLAY_PC = 18

        <Description("ASA Sorting Display PC")>
        ASA_SORTING_DISPLAY_PC = 19

        <Description("ASA Hopper Display 1&2")>
        ASA_HOPPER_DISPLAY_01_02 = 20

        <Description("ASA Hopper Display 3&4")>
        ASA_HOPPER_DISPLAY_03_04 = 21

        <Description("ASA Hopper Display 5&6")>
        ASA_HOPPER_DISPLAY_05_06 = 22

        <Description("ASA Hopper Display 7&8")>
        ASA_HOPPER_DISPLAY_07_08 = 23

        <Description("ASA Hopper Display 9&10")>
        ASA_HOPPER_DISPLAY_09_10 = 24

        <Description("ASA Hopper Display 11&12")>
        ASA_HOPPER_DISPLAY_11_12 = 25

        <Description("ASA Hopper Display 13&14")>
        ASA_HOPPER_DISPLAY_13_14 = 26

        <Description("ASA Hopper Display 15")>
        ASA_HOPPER_DISPLAY_15 = 27

        <Description("======Development PC======")>
        DEVELOPMENT_PC = 28

        <Description("TSA Washdeck Control PC - Dryer Side")>
        TSA_WASHDECK_CONTROL_PC_2 = 29

        <Description("TSA TF Display 1-16")>
        TSA_TOWEL_FOLD_01_16 = 30

        <Description("TSA TF Display 17-22")>
        TSA_TOWEL_FOLD_17_22 = 31

        <Description("TSA ES Productivity Display")>
        TSA_ENGINEERING_SHOP_PRODUCTIVITY_PC = 32

        <Description("TSA FW Productivity Display 1")>
        TSA_FLAT_WORK_PRODUCTIVITY_DISPLAY_01 = 33

        <Description("TSA FW Productivity Display 2")>
        TSA_FLAT_WORK_PRODUCTIVITY_DISPLAY_02 = 34

        <Description("TSA FW Productivity Display 3")>
        TSA_FLAT_WORK_PRODUCTIVITY_DISPLAY_03 = 35

        <Description("TSA FW Productivity Display 4")>
        TSA_FLAT_WORK_PRODUCTIVITY_DISPLAY_04 = 36

        <Description("TSA FW Productivity Display 5")>
        TSA_FLAT_WORK_PRODUCTIVITY_DISPLAY_05 = 37

        <Description("TSA FW Productivity Display 6")>
        TSA_FLAT_WORK_PRODUCTIVITY_DISPLAY_06 = 38

        <Description("TSA FW Productivity Display 7")>
        TSA_FLAT_WORK_PRODUCTIVITY_DISPLAY_07 = 39

        <Description("TSA FW Productivity Display 8")>
        TSA_FLAT_WORK_PRODUCTIVITY_DISPLAY_08 = 40

        <Description("TSA Prod Office TEAM Display")>
        TSA_PRODUCTION_OFFICE_TEAM_DISPLAY = 41

        <Description("NSA Hopper Display 1 to 4")>
        NSA_HOPPER_DISPLAY_01_04 = 42

        <Description("NSA Hopper Display 5 to 8")>
        NSA_HOPPER_DISPLAY_05_08 = 43

        <Description("NSA Hopper Display 9 to 12")>
        NSA_HOPPER_DISPLAY_09_12 = 44

        <Description("NSA Hopper Display 13 to 16")>
        NSA_HOPPER_DISPLAY_13_16 = 45

        <Description("NSA Hopper Display 17 to 20")>
        NSA_HOPPER_DISPLAY_17_20 = 46

        <Description("NSA Hopper Display 21 to 22")>
        NSA_HOPPER_DISPLAY_21_22 = 47

        <Description("TSA Hopper Display 1 to 2")>
        TSA_HOPPER_DISPLAY_01_02 = 48

        <Description("TSA Hopper Display 3 to 4")>
        TSA_HOPPER_DISPLAY_03_04 = 49

        <Description("TSA Hopper Display 5 to 6")>
        TSA_HOPPER_DISPLAY_05_06 = 50

        <Description("TSA Hopper Display 7 to 8")>
        TSA_HOPPER_DISPLAY_07_08 = 51

        <Description("TSA Hopper Display 9 to 10")>
        TSA_HOPPER_DISPLAY_09_10 = 52

        <Description("TSA Hopper Display 11 to 12")>
        TSA_HOPPER_DISPLAY_11_12 = 53

        <Description("TSA Hopper Display 13 to 14")>
        TSA_HOPPER_DISPLAY_13_14 = 54

        <Description("TSA Hopper Display 15 to 16")>
        TSA_HOPPER_DISPLAY_15_16 = 55

        <Description("TSA Hopper Display 17 to 18")>
        TSA_HOPPER_DISPLAY_17_18 = 56

        <Description("TSA Hopper Display 19 to 20")>
        TSA_HOPPER_DISPLAY_19_20 = 57

        <Description("TSA Hopper Display 21 to 22")>
        TSA_HOPPER_DISPLAY_21_22 = 58

        <Description("TSA Hopper Display 23 to 24")>
        TSA_HOPPER_DISPLAY_23_24 = 59

        <Description("TSA Hopper Display 25 to 26")>
        TSA_HOPPER_DISPLAY_25_26 = 60

        <Description("TSA Hopper Display 27 to 28")>
        TSA_HOPPER_DISPLAY_27_28 = 61

        <Description("TSA Hopper Display 29 to 30")>
        TSA_HOPPER_DISPLAY_29_30 = 62

        <Description("TSA Hopper Display 31 to 32")>
        TSA_HOPPER_DISPLAY_31_32 = 63

        <Description("TSA Hopper Display 33 to 34")>
        TSA_HOPPER_DISPLAY_33_34 = 64

        <Description("TSA FW Productivity Display 9")>
        TSA_FLAT_WORK_PRODUCTIVITY_DISPLAY_09 = 65

    End Enum

    ''' <summary>
    ''' This enum series has to match with the table "LINT_software.LINT_Component_Lookup" in the database
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum LintComponents As Integer
        UNKNOWN_COMPONENT = 0
        VERTICAL_CONVEYOR = 1
        HORIZONTAL_CONVEYOR = 2
        DISCHARGER = 3
        STORAGE_RAIL = 4
        INCLINED_CONVEYOR = 5
        LIFTING_AID = 6
        PLC_PROCESSOR = 7
        PLC_INPUTS_OUTPUTS = 8
        INVERTER_DRIVE = 9
        BELT_CONVEYOR = 10
        CART_DUMPER = 11
        SORTING_STATION = 12
        WEIGH_SCALE = 13
        BUFFER_POSITION = 14
        BAG_CLOSER = 15
        BAG_STACKER = 16
        WASHER_INTERFACE = 17
        PICKER_INTERFACE = 18
        IRONER = 19
        FEEDER = 20
        FOLDER_STACKER = 21
        TOWEL_FOLDER = 22
        BLANKET_FOLDER = 23
        TUNNEL_WASHER = 24
        WASHER_EXTRACTOR = 25
        DRYER = 26
        IRONER_SCANNER = 27
        BURNNER = 28
        PNEUMATIC = 29
        NETWORK_COMMUNICATION = 30
        CHAIN_CONVEYOR = 31
        CIRCUIT_BREAKER = 32
        SENSOR_PROXIMITY = 33
        MOTOR_PROTECTION = 34
        SYSTEM_CONTROL = 35
    End Enum

    Public Enum MessageFaultSeverity As Integer
        CRITICAL_FAULT = 1
        URGENT_ACTION_REQUIRED = 2
        HIGH_PRIORITY_FAULT = 3
        MEDIUM_PRIORITY_FAULT = 4
        LOW_PRIORITY_FAULT = 5
    End Enum

    Public Enum MessageType As Integer
        UNKNOWN_MESSAGE_TYPE = 0
        GENERAL_FAULT_MESSAGE = 1
        EXCEPTION_MESSAGE = 2
        ELECTRICAL_SYSTEM_MESSAGE = 3
        MECHANICAL_SYSTEM_MESSAGE = 4
        COMPUTER_PLC_SYSTEM_MESSAGE = 5
        PRODUCTION_SYSTEM_MESSAGE = 6
        DATA_MESSAGE = 7
    End Enum

    Public Enum TeamMachineStatus
        MachineAvailable
        MachineMaintenanceInProgress
        MachineMaintenanceRequested
        MachinePmInProgress
    End Enum

    Public Enum TeamSessionChangeReason

        <Description("Unknown")>
        Unknown = 0

        <Description("Productive")>
        MachineProductive = 18

        <Description("Unplanned Idle")>
        MachineUnproductive = 10

        <Description("Machine Stopped")>
        MachineStop = 2

        <Description("Maint. in Progress")>
        MachineMaintenanceByEngineering = 21

        <Description("Pending Maint.")>
        MachineMaintenanceByProduction = 20

        <Description("Faulted")>
        MachineFaulted = 19

        <Description("Break in Progress")>
        MachineBreakInProgress = 17

        <Description("Machine PM")>
        MachinePmInProgress = 23

    End Enum

    ''' <summary>
    ''' Default Futurail Access Levels
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum DefaultRailAccessLevel As Integer

        NO_ACCESS = 0

        'Default
        AREA_SUPERVISOR = 8256953

        ENGINEER_CRAFT_SUPPORT = 4061682
        ENGINEER_FOREMAN = 4062714
        ENGINEER_LSM = 3997170
        ENGINEER_LSM_JR = 39633141
        ENGINEER_MANAGER = 4063226
        ENGINEER_MANAGER_TEAM_LEADER = 4063226
        OPERATIONS_MANAGER = 8257465
        OUTSIDE_VENDOR = NO_ACCESS
        PLANT_MANAGER = 8257465
        PRODUCTION_MANAGER = 8257465
        SYSTEM_ADMINISTRATOR = 8388607
        SYSTEM_OPERATOR = 3963314
        SYSTEM_OPERATOR_SR = 8256953

        'TSA
        TSA_AREA_SUPERVISOR = AREA_SUPERVISOR

        TSA_ENGINEER_CRAFT_SUPPORT = ENGINEER_CRAFT_SUPPORT
        TSA_ENGINEER_FOREMAN = ENGINEER_FOREMAN
        TSA_ENGINEER_LSM = ENGINEER_LSM
        TSA_ENGINEER_LSM_JR = ENGINEER_LSM_JR
        TSA_ENGINEER_MANAGER = ENGINEER_MANAGER
        TSA_ENGINEER_MANAGER_TEAM_LEADER = ENGINEER_MANAGER
        TSA_OPERATIONS_MANAGER = OPERATIONS_MANAGER
        TSA_OUTSIDE_VENDOR = NO_ACCESS
        TSA_PLANT_MANAGER = PLANT_MANAGER
        TSA_PRODUCTION_MANAGER = PRODUCTION_MANAGER
        TSA_PRODUCTION_OPERATOR = NO_ACCESS
        TSA_SYSTEM_ADMINISTRATOR = SYSTEM_ADMINISTRATOR
        TSA_SYSTEM_OPERATOR = SYSTEM_OPERATOR
        TSA_SYSTEM_OPERATOR_SR = SYSTEM_OPERATOR_SR
        TSA_SYSTEM_SUPPORT = NO_ACCESS
        TSA_UNASSIGNED = NO_ACCESS

        'NSA
        NSA_AREA_SUPERVISOR = AREA_SUPERVISOR

        NSA_ENGINEER_CRAFT_SUPPORT = ENGINEER_CRAFT_SUPPORT
        NSA_ENGINEER_FOREMAN = ENGINEER_FOREMAN
        NSA_ENGINEER_LSM = ENGINEER_LSM
        NSA_ENGINEER_LSM_JR = ENGINEER_LSM_JR
        NSA_ENGINEER_MANAGER = ENGINEER_MANAGER
        NSA_ENGINEER_MANAGER_TEAM_LEADER = ENGINEER_MANAGER
        NSA_OPERATIONS_MANAGER = OPERATIONS_MANAGER
        NSA_OUTSIDE_VENDOR = NO_ACCESS
        NSA_PLANT_MANAGER = PLANT_MANAGER
        NSA_PRODUCTION_MANAGER = PRODUCTION_MANAGER
        NSA_PRODUCTION_OPERATOR = NO_ACCESS
        NSA_SYSTEM_ADMINISTRATOR = SYSTEM_ADMINISTRATOR
        NSA_SYSTEM_OPERATOR = SYSTEM_OPERATOR_SR
        NSA_SYSTEM_OPERATOR_SR = SYSTEM_OPERATOR_SR
        NSA_SYSTEM_SUPPORT = NO_ACCESS
        NSA_UNASSIGNED = NO_ACCESS

        'ASA
        ASA_AREA_SUPERVISOR = AREA_SUPERVISOR

        ASA_ENGINEER_CRAFT_SUPPORT = ENGINEER_CRAFT_SUPPORT
        ASA_ENGINEER_FOREMAN = ENGINEER_FOREMAN
        ASA_ENGINEER_LSM = ENGINEER_LSM
        ASA_ENGINEER_LSM_JR = ENGINEER_LSM_JR
        ASA_ENGINEER_MANAGER = ENGINEER_MANAGER
        ASA_OPERATIONS_MANAGER = OPERATIONS_MANAGER
        ASA_OUTSIDE_VENDOR = NO_ACCESS
        ASA_PLANT_MANAGER = PLANT_MANAGER
        ASA_PRODUCTION_MANAGER = PRODUCTION_MANAGER
        ASA_PRODUCTION_OPERATOR = NO_ACCESS
        ASA_SYSTEM_ADMINISTRATOR = SYSTEM_ADMINISTRATOR
        ASA_SYSTEM_OPERATOR = SYSTEM_OPERATOR_SR
        ASA_SYSTEM_OPERATOR_SR = SYSTEM_OPERATOR_SR
        ASA_SYSTEM_SUPPORT = NO_ACCESS
        ASA_UNASSIGNED = NO_ACCESS

        'Unknown
        UNKNOWN_AREA_SUPERVISOR = NO_ACCESS

        UNKNOWN_ENGINEER_CRAFT_SUPPORT = NO_ACCESS
        UNKNOWN_ENGINEER_FOREMAN = NO_ACCESS
        UNKNOWN_ENGINEER_LSM = NO_ACCESS
        UNKNOWN_ENGINEER_LSM_JR = NO_ACCESS
        UNKNOWN_ENGINEER_MANAGER = NO_ACCESS
        UNKNOWN_ENGINEER_MANAGER_TEAM_LEADER = NO_ACCESS
        UNKNOWN_OPERATIONS_MANAGER = NO_ACCESS
        UNKNOWN_OUTSIDE_VENDOR = NO_ACCESS
        UNKNOWN_PLANT_MANAGER = NO_ACCESS
        UNKNOWN_PRODUCTION_MANAGER = NO_ACCESS
        UNKNOWN_PRODUCTION_OPERATOR = NO_ACCESS
        UNKNOWN_SYSTEM_ADMINISTRATOR = NO_ACCESS
        UNKNOWN_SYSTEM_OPERATOR = NO_ACCESS
        UNKNOWN_SYSTEM_OPERATOR_SR = NO_ACCESS
        UNKNOWN_SYSTEM_SUPPORT = NO_ACCESS
        UNKNOWN_UNASSIGNED = NO_ACCESS
    End Enum

    Public Enum LintAccessLevel As Integer
        NO_RIGHT = 0 '0
        READ_DATA_ONLY = 1 '1
        EDIT_USER_RAIL_OPTIONS = 2 '2
        EDIT_USER_WORK_LOCATION = 4 '3
        EDIT_USER_SYSTEM_CONFIGURATION = 8 '4
        EDIT_USER_EMPLOYEE_ID = 16 '5
        EDIT_USER_TYPE = 32 '6
        EDIT_USER_PRODUCTIVITY_TARGETS = 64 '7
        EDIT_USER = 128 '8
        ADD_USER = 256 '9
        DELETE_USER = 512 '10
        EDIT_CARD_ASSIGNMENT = 1024 '11
        ADD_CARD = 2048 '12
        EDIT_CARD = 4096 '13
        DELETE_CARD = 8192 '14
        RETURN_CARD = 16384 '15
        EDIT_CARD_NUMBER = 32768 '16
        EDIT_SHIFT = 65536 '17
        EDIT_USER_NAME = 131072 '18
        EDIT_USER_ACTIVE_STATUS = 262144 '19
        LOG_OPERATOR_OFF_OF_STATION = 524288 '20
        TEAM_SET_MACHINE_STATUS = 1048576 '21
    End Enum

    ''' <summary>
    ''' Default LINT User Type. This enum series has to match with the table "LINT_software.LINT_User_Type_Lookup" in the database
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum LintUserType As Integer

        <Description("Blank")>
        BLANK = -1

        <Description("Unassigned")>
        UNASSIGNED = 0

        <Description("Admin")>
        SYSTEM_ADMINISTRATOR = 1

        <Description("System Operator")>
        SYSTEM_OPERATOR = 2

        <Description("Area Supervisor")>
        AREA_SUPERVISOR = 4

        <Description("Production Manager")>
        PRODUCTION_MANAGER = 8

        <Description("Plant Manager")>
        PLANT_MANAGER = 16

        <Description("Craft Support")>
        ENGINEER_CRAFT_SUPPORT = 32

        <Description("LSM")>
        ENGINEER_LSM = 64

        <Description("Engineering Manager")>
        ENGINEER_MANAGER = 128

        <Description("Vendor")>
        OUTSIDE_VENDOR = 256

        <Description("Systems Support")>
        SYSTEM_SUPPORT = 512

        <Description("Production Operator")>
        PRODUCTION_OPERATOR = 1024

        <Description("Foreman")>
        ENGINEER_FOREMAN = 2048

        <Description("LSM Jr.")>
        ENGINEER_LSM_JR = 4096

        <Description("System Operator Sr.")>
        SYSTEM_OPERATOR_SR = 8192

        <Description("Operations Manager")>
        OPERATIONS_MANAGER = 16384

        <Description("Engineering Manager Team Leader")>
        ENGINEER_MANAGER_TEAM_LEADER = 32768

    End Enum

    ''' <summary>
    ''' This list is mapped to the database table "LINT_software.LINT_User_List""
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum RailAccessOptions As Integer

        ''' <summary>
        '''Default Rail Access Options
        ''' </summary>
        ''' <remarks></remarks>
        UNKNOWN = 0 '0

        CATEGORY_SETUP = 1 '1
        ACCOUNT_SETUP = 2 '2
        SYSTEM_CONFIGURATION = 4 '3
        DELETE_BAGS = 8 '4
        EDIT_BAGS = 16 '5
        CHANGE_SEQUENCES = 32 '6
        CALIBRATION = 64 '7
        CALL_OFF_EDIT = 128 '8
        RUN_DOWN_SYSTEM = 256 '9
        CALL_OFF_RESET = 512 '10
        BAG_ZERO_DESTINATION_EDIT = 1024 '11
        BAG_CATEGORY_EDIT = 2048 '12
        BAG_ACCOUNT_EDIT = 4096 '13
        BAG_WEIGHT_EDIT = 8192 '14
        BAG_SOURCE_BIN_EDIT = 16384 '15
        BAG_STORAGE_DESTINATION_EDIT = 32768 '16
        BAG_DROP_DESTINATION_EDIT = 65536 '17
        BAG_RF_TAG_EDIT = 131072 '18
        BAG_PLC_ID_EDIT = 262144 '19
        BAG_CALL_ID_EDIT = 524288 '20
        EXPRESS_PRODUCT_SELECTION = 1048576 '21
        BLOCK_UNBLOCK_RAIL = 2097152 '22
        RESET_PRODUCTION_NUMBERS = 4194304 '23
    End Enum

    Public Enum LintAdminAccessLevel As Integer

        ''' <summary>
        ''' Default LINT Administration Level
        ''' </summary>
        ''' <remarks></remarks>
        NO_RIGHT = 0

        READ_DATA_ONLY = 1
        READ_AND_EDIT = 2
        READ_EDIT_AND_ADD = 3
        READ_EDIT_ADD_AND_ASSIGN = 4
        ADMIN = 5
    End Enum

    Public Enum Plant As Integer

        <Description("Unknown Plant")>
        UNKNOWN = 0

        <Description("TSA")>
        TSA = 1

        <Description("NSA")>
        NSA = 2

        <Description("ASA")>
        ASA = 3

        <Description("All Plants")>
        ALL_PLANTS = 4

        <Description("FLO")>
        FLO = 5

        <Description("Multiple Plants")>
        MULTIPLE_PLANTS = 6

    End Enum

    Public Enum DisplayType As Integer

        <Description("Station")>
        STATION = 0

        <Description("Admin")>
        ADMIN = 1

        <Description("Monitoring Dashboard")>
        MONITORING_DASHBOARD = 2

        <Description("Summary")>
        SUMMARY = 3

        <Description("Config")>
        CONFIG = 4

        <Description("TABLEAU")>
        TABLEAU = 5

    End Enum

    ''' <summary>
    ''' The IDs must match the table LINT_software.LINT_Application_Info in the database
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum LintApplicationId As Integer

        <Description("Unknown")>
        UNKNOWN = 0

        <Description("TSA Diagnostics Interface")>
        TSA_DIAGNOSTICS_INTERFACE = 6

        <Description("TSA Rail System")>
        TSA_RAIL_SYSTEM = 7

        <Description("TSA Data Collection")>
        TSA_DATA_COLLECTION = 8

        <Description("ASA Rail System")>
        ASA_RAIL_SYSTEM = 14

        <Description("NSA Rail System")>
        NSA_RAIL_SYSTEM = 17

        <Description("ASA Data Collection")>
        ASA_DATA_COLLECTION = 18

        <Description("NSA Data Collection")>
        NSA_DATA_COLLECTION = 19

        <Description("LINT Data Automatic Transfer Portal")>
        LINT_DATA_AUTOMATIC_TRANSFER_PORTAL = 20

        <Description("ASA Productivity Display")>
        ASA_PRODUCTIVITY_DISPLAY = 21

        <Description("TSA Workflow Data Collection")>
        TSA_WORKFLOW_DATA_COLLECTION = 22

        <Description("TSA Workflow System")>
        TSA_WORKFLOW_SYSTEM = 23

        <Description("TSA Engineering Shop Washdeck Display")>
        TSA_ENGINEERING_SHOP_WASHDECK_DISPLAY = 24

        <Description("LINT Alarm Data Collection")>
        LINT_ALARM_DATA_COLLECTION = 25

        <Description("TSA TEAM System Data Collection")>
        TSA_TEAM_DATA_COLLECTION = 26

        <Description("TSA TEAM Display Ironer 1")>
        TSA_TEAM_Display_Ironer_1 = 27

        <Description("TSA TEAM Display Ironer 2")>
        TSA_TEAM_Display_Ironer_2 = 28

        <Description("TSA TEAM Display Ironer 3")>
        TSA_TEAM_Display_Ironer_3 = 29

        <Description("TSA TEAM Display Ironer 4")>
        TSA_TEAM_Display_Ironer_4 = 30

        <Description("TSA TEAM Display Ironer 5")>
        TSA_TEAM_Display_Ironer_5 = 31

        <Description("TSA TEAM Display Ironer 6")>
        TSA_TEAM_Display_Ironer_6 = 32

        <Description("TSA TEAM Display Ironer 7")>
        TSA_TEAM_Display_Ironer_7 = 33

        <Description("TSA TEAM Display Ironer 8")>
        TSA_TEAM_Display_Ironer_8 = 34

        <Description("TSA TEAM Display Production Office")>
        TSA_TEAM_Display_Production_Office = 35

        <Description("TSA TEAM Display Engineering Office")>
        TSA_TEAM_Display_Engineering_Office = 36

        <Description("TSA Sorting Displays 1 & 2")>
        TSA_Sorting_1_2 = 37

        <Description("TSA Sorting Displays 3 & 4")>
        TSA_Sorting_3_4 = 38

        <Description("TSA Sorting Displays 5 & 6")>
        TSA_Sorting_5_6 = 39

        <Description("TSA Sorting Displays 7 & 8")>
        TSA_Sorting_7_8 = 40

        <Description("TSA Sorting Displays 9 & 10")>
        TSA_Sorting_9_10 = 41

        <Description("TSA Sorting Displays 11 & 12")>
        TSA_Sorting_11_12 = 42

        <Description("TSA Sorting Displays 13 & 14")>
        TSA_Sorting_13_14 = 43

        <Description("TSA Sorting Displays 15 & 16")>
        TSA_Sorting_15_16 = 44

        <Description("TSA Sorting Displays 17 & 18")>
        TSA_Sorting_17_18 = 45

        <Description("TSA Sorting Displays 19 & 20")>
        TSA_Sorting_19_20 = 46

        <Description("TSA Sorting Displays 21 & 22")>
        TSA_Sorting_21_22 = 47

        <Description("TSA Sorting Displays 23 & 24")>
        TSA_Sorting_23_24 = 48

        <Description("TSA Sorting Displays 25 & 26")>
        TSA_Sorting_25_26 = 49

        <Description("TSA Sorting Displays 27 & 28")>
        TSA_Sorting_27_28 = 50

        <Description("TSA Sorting Displays 29 & 30")>
        TSA_Sorting_29_30 = 51

        <Description("TSA Sorting Displays 31 & 32")>
        TSA_Sorting_31_32 = 52

        <Description("TSA Sorting Displays 33 & 34")>
        TSA_Sorting_33_34 = 53

        <Description("Lint Operator Login Service")>
        LintOperatorLoginService = 54

    End Enum

    Public Enum LintServiceType
        UNKNOWN = 0
        WCF_LINT_ALARM = 1
        WCF_LINT_CHAT = 2
        TSA_WORKFLOW = 3
        WCF_LINT_RAIL_INFO = 4
        WCF_APP_SERVER_SERVICE_CONTROLLER = 5
        TSA_TEAM_DATA = 6
        WCF_LINT_RAIL_INFO_7851 = 7
        WCF_APP_SERVER_SERVICE_CONTROLLER_7851 = 8
    End Enum

    ''' <summary>
    ''' This list is mapped to the database table "LINT_software.LINT_System_Parameter_Lookup"
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum LintSystemParameterId As Integer
        FirstShiftStartHour = 1
        FirstShiftStartMinute = 2
        FirstShiftDurationInHours = 3
        FirstShift1stBreakStartHour = 4
        FirstShift1stBreakStartMinute = 5
        FirstShift1stBreakDurationInHours = 6
        FirstShift2ndBreakStartHour = 7
        FirstShift2ndBreakStartMinute = 8
        FirstShift2ndBreakDurationInHours = 9
        FirstShift3rdBreakStartHour = 10
        FirstShift3rdBreakStartMinute = 11
        FirstShift3rdBreakDurationInHours = 12
        SecondShiftStartHour = 13
        SecondShiftStartMinute = 14
        SecondShiftDurationInHours = 15
        SecondShift1stBreakStartHour = 16
        SecondShift1stBreakStartMinute = 17
        SecondShift1stBreakDurationInHours = 18
        SecondShift2ndBreakStartHour = 19
        SecondShift2ndBreakStartMinute = 20
        SecondShift2ndBreakDurationInHours = 21
        SecondShift3rdBreakStartHour = 22
        SecondShift3rdBreakStartMinute = 23
        SecondShift3rdBreakDurationInHours = 24
        ThirdShiftStartHour = 25
        ThirdShiftStartMinute = 26
        ThirdShiftDurationInHours = 27
        ThirdShift1stBreakStartHour = 28
        ThirdShift1stBreakStartMinute = 29
        ThirdShift1stBreakDurationInHours = 30
        ThirdShift2ndBreakStartHour = 31
        ThirdShift2ndBreakStartMinute = 32
        ThirdShift2ndBreakDurationInHours = 33
        ThirdShift3rdBreakStartHour = 34
        ThirdShift3rdBreakStartMinute = 35
        ThirdShift3rdBreakDurationInHours = 36
        EnableWorkflowSystem = 37
        FirstShift1stBreakIncludeUnitedTemp = 38
        FirstShift2ndBreakIncludeUnitedTemp = 39
        FirstShift3rdBreakIncludeUnitedTemp = 40
        SecondShift1stBreakIncludeUnitedTemp = 41
        SecondShift2ndBreakIncludeUnitedTemp = 42
        SecondShift3rdBreakIncludeUnitedTemp = 43
        ThirdShift1stBreakIncludeUnitedTemp = 44
        ThirdShift2ndBreakIncludeUnitedTemp = 45
        ThirdShift3rdBreakIncludeUnitedTemp = 46
        NetTcpBindingSecurityMode = 47
        WsHttpBindingSecurityMode = 48
        UseTeamService = 49
        UseRailService = 50
        UseTeamDashboardCleanworkMachinePacingService = 51
        TsaRailQaInstallPath = 52
        TsaRailProdInstallPath = 53
        TsaRailCurrentInstallPath = 54
        RostrApiKey = 55
        PickerProjectCurrentPhase = 56
    End Enum

    ''' <summary>
    '''  Connection display status for Sorting Displays
    ''' </summary>
    Public Enum SortingDisplayStatus As Integer

        <Description("Sorting Display Connected")>
        Connected = 1

        <Description("Sorting Display Has Not Been Seen Yet")>
        ConnectionPending = 2

        <Description("Lost Connection to Sorting Display")>
        LostConnection = 3

    End Enum

    Public Enum SwitchGateDirection As Integer
        NorthLeftTurn = 0
        NorthRightTurn = 1
        SouthLeftTurn = 2
        SouthRightTurn = 3
        EastLeftTurn = 4
        EastRightTurn = 5
        WestLeftTurn = 6
        WestRightTurn = 7
    End Enum

End Module