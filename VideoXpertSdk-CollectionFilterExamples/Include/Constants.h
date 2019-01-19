#pragma once
#include "FilterExamples.h"

/// <summary>
/// The maximum number of results to show in the result tables.
/// </summary>
static const int kMaxResults = 10;

/// <summary>
/// Provides the options that will be presented to the user in the various menus.
/// </summary>
namespace Options {
    static const vector<ConsolePrinter::MenuOption> kMainMenu = {
        {"1", "1) Search For DataSource By Number", static_cast<option_method_pointer>(FilterExamples::OptionSearchForDataSourceByNumber)},
        {"2", "2) Search For Device(s) By IP", static_cast<option_method_pointer>(FilterExamples::OptionSearchForDevicesByIp)},
        {"3", "3) Search For DataSources Using Multiple Filters", static_cast<option_method_pointer>(FilterExamples::OptionSearchDataSourcesMultiFilter)},
        {"4", "4) Search For Events Using Multiple Filters", static_cast<option_method_pointer>(FilterExamples::OptionSearchEventsMultiFilter)},
        {"5", "5) Search For DataSources Using An Advanced Query", static_cast<option_method_pointer>(FilterExamples::OptionSearchForDataSourcesUsingAdvancedQuery)},
        {"6", "6) Search For Events Using An Advanced Query", static_cast<option_method_pointer>(FilterExamples::OptionSearchForEventsUsingAdvancedQuery)},
        {"0", "\n0) Exit", nullptr}
    };

    static const vector<ConsolePrinter::SearchOption> kFieldOptions = {
        {"1", "1) Number", "number"},
        {"2", "2) Name", "name"},
        {"3", "3) ID", "id"},
        {"4", "4) IP", "ip"},
        {"5", "5) Recording", "recording"},
        {"6", "6) Type", "type"}
    };

    static const vector<ConsolePrinter::SearchOption> kEventFieldOptions = {
        {"1", " 1) Ack State", "ack_state"},
        {"2", " 2) Ack User", "ack_user"},
        {"3", " 3) Generator Device Id", "generator_device_id"},
        {"4", " 4) Id", "id"},
        {"5", " 5) Notifies", "notifies"},
        {"6", " 6) Situation Type", "situation_type"},
        {"7", " 7) Source Device Id", "source_device_id"},
        {"8", " 8) Source User Name", "source_user_name"},
        {"9", " 9) Severity", "severity"},
        {"10", "10) Time", "time"}
    };

    static const vector<ConsolePrinter::SearchOption> kConnectiveOptions = {
        {"1", "1) and", "and"},
        {"2", "2) or", "or"},
        {"3", "3) Submit the query", ""}
    };

    static const vector<ConsolePrinter::SearchOption> kComparisonOptions = {
        {"1", "1) (eq) equal", " eq "},
        {"2", "2) (likei) contains", " likei "},
        {"3", "3) (ne) not equal", " ne "},
        {"4", "4) (gt) greater than", " gt "},
        {"5", "5) (gte) greater than or equal to", " gte "},
        {"6", "6) (lt) less than", " lt "},
        {"7", "7) (lte) less than or equal to", " lte "}
    };
}

/// <summary>
/// Contains commonly used messages.
/// </summary>
namespace Messages {
    static const char* kEnterIp = "\nEnter system IP: ";

    static const char* kEnterName = "Enter system user name: ";

    static const char* kEnterPassword = "Enter system password: ";

    static const char* kLicenseError = "\nERROR: This system has not been licensed to run this integration and the grace period has expired.\n\nA license for this integration must be activated on the system to proceed.\n\n";

    static const char* kLoginError = "\nERROR: Failed to login with error code: %s\n\n";

    static const char* kLicenseWarning = "WARNING: No system license found. Grace period expires %s\n\n";

    static const char* kDefaultKeyError = "\nERROR: The kLicenseKey variable is still set to the default value (located in .\\Source\\Main.cpp).\nYou will NOT be able to connect to ANY VideoXpert system until the value of kLicenseKey is set.";
}

/// <summary>
/// Contains enum translation strings for various search result fields.
/// </summary>
namespace PrintValues {
    static const char* kDeviceTypeStrings[] = {
        "Accessory Server", "Access Control", "VxPro", "Camera", "Core", "Decoder", "Encoder", "External", "Generic",
        "MediaGateway", "Monitor", "Recorder", "UI", "Unknown"
    };

    static const char* kDataSourceTypeStrings[] = {
        "Unknown", "Video", "Audio"
    };

    static const char* kDeviceStatusStrings[] = {
        "Unknown", "Offline",  "Online"
    };

    static const char* kAckStateStrings[] = {
        "Unknown",  "Ack Needed", "Acked", "Auto-Acked", "No Ack Needed", "Silenced"
    };

    static const char* kFilterItemStrings[] = {
        "kNone", "kCount", "kDataSourceId", "kSearchStartTime", "kSearchEndTime", "kName", "kId", "kStart", "kType", "kSituationType",
        "kUnassigned", "kDataSourceNumber", "kDescription", "kModifiedSince", "kTime", "kEndTime", "kStartTime", "kEvent", "kFramerate",
        "kClientType", "kOwned", "kOwner", "kUsername", "kAllTags", "kCapturing", "kIp", "kNumber", "kRecording", "kState", "kCommissioned",
        "kModel", "kSerial", "kVendor", "kVersion", "kAckState", "kAckUser", "kGeneratorDeviceId", "kNotifies", "kSeverity", "kSourceDeviceId",
        "kSourceUserName", "kPercentComplete", "kSize", "kStatus", "kResourceId", "kInternal", "kAudibleNotify", "kLog", "kNotify",
        "kResourceType", "kLinked", "kAllPrivateTags", "kManualRecording", "kFirstName", "kLastName", "kHasProperty", "kHasStatus",
        "kDataSourceAllTags", "kDataSourceAllPrivateTags", "kDataSourceName", "kServicePropertyId", "kImageType", "kAdvancedQuery", "kTagsAll",
        "kEnabled", "kInitiated", "kDataStorageId", "kTrashed", "kDataSourceType", "kDeviceId", "kDriverType", "kEncoding", "kFolder", "kGroupId",
        "kHasFolderTags", "kLayerName", "kLicenseRequired", "kLocked", "kParentId", "kProvider"
    };

    static const char* kErrorStrings[] = {
        "UnknownError: An error or unknown value was returned.",
        "OK: The action was successful.",
        "UnsupportedVersion: The VideoXpert system version is not supported.",
        "InsufficientSize: The size value was not sufficient enough to allocate the collection.",
        "InvalidLoginInfo: The login credentials were invalid.",
        "ActionUnavailable: The attempted action is unsupported by the system.",
        "InvalidParameters: A parameter was invalid.",
        "CommunicationError: There was an error communicating to the device.",
        "InvalidLicense: No valid license was found on the VideoXpert system.",
        "CameraUnavailable: Camera is unavailable, data cannot be retrieved at this time.",
        "EdgeOfStream: No further stream data is currently available (the edge of a currently\nrecording clip has been reached); more data will be available shortly.",
        "EndOfStream: No further stream data is available (the end of all recorded data has\nbeen reached; no further data is currently be recorded).",
        "NoAvailableStreams: The server is unable to initiate any new stream sessions due to\nhaving reached its stream count capacity.",
        "StorageUnavailable: Storage is unavailable, data cannot be retrieved at this time.",
        "ExportDataUnretrievable: The data needed to perform the export operation can not be\nretrieved.",
        "ExportStorageFull: The export storage location does not have enough free space to\nstore the export.",
        "ExportStorageUnauthenticated:  The export storage location is not accessible due to\ninvalid credentials.",
        "ExportStorageUnavailable: The export storage location is not accessible; this may be\ndue to an invalid location, network issue, or storage issue.",
        "Conflict: The requested operation is not possible due to a conflict with the resource.\nTypically this is due to a violation of a uniqueness property on one of the\nresources fields.",
        "InsufficientResources: The server has insufficient resources to satisfy the request.",
        "NotReady: The server is not in an appropriate state to be able to service this\nrequest. The server requires intervention in order to resolve this.",
        "NotReadyUnauthenticated: The server is not in an appropriate state to be able to\nservice this request due to an authentication issue between it and another entity.\nThe server requires intervention in order to resolve this.",
        "NotReadyUnauthorized: The server is not in an appropriate state to be able to service\nthis request due to an authorization issue between it and another entity.\nThe server requires intervention in order to resolve this.",
        "OperationFailed: The requested operation failed.",
        "ResponseTooLarge: The server is incapable of handling the client request due to\nthe size of the resulting response. What constitutes \"too large\" is entirely up\nto the server.",
        "ActivationConflict: The license that was supplied has an activation conflict with\nan existing license(e.g.duplicate activation IDs).",
        "ActivationHostNotFound: The activation failed due to communication error with the\nFNO licensing server.",
        "ActivationFailed: The activation failed.",
        "IncompatibleLicense: The license that was supplied is not compatible with the\ndevice and/or system that it is being applied to.",
        "LicenseCountExceeded: A valid license is available but the available count on\nthat license is fully utilized.",
        "LicenseRequired: A valid license is required to utilize this method on the\nresource; no valid license found.",
        "LicenseReqLdapAdmin: Unable to apply the license; valid LDAP administrator\ncredentials are required.",
        "NoLicense: Unable to commission (or float) a feature because no valid license\nis available for it.",
        "CameraInUse: Camera is in use (or the usage dwell time is active) by same or\nhigher authority user.",
        "CameraLocked: Camera is locked by same or higher authority user.",
        "NeedOverride: Locked by lower authority user, may override.",
        "InvalidValue: An attempt to set an invalid value on a writable field was made.\nThe value may be invalid due to being out of range, unavailable, etc.",
        "PortInUse: An attempt to set a new port number failed because the port number\nis already in use.",
        "ReadOnlyField: An attempt to edit a read-only field was made.",
        "ResourceLocked: An attempt to edit a locked resource was made by a user that\ndoes not own the IVxResourceLock.",
        "AuthExpired: A request was made using expired authentication credentials.",
        "PasswordReqMoreDigits: A password with an insufficient number of digits was\nsupplied in an attempt to create a new user password.",
        "PasswordReqMoreLower: A password with an insufficient number of lowercase letters\nwas supplied in an attempt to create a new user password.",
        "PasswordReqMoreSpecial: A password with an insufficient number of special\ncharacters was supplied in an attempt to create a new user password.",
        "PasswordReqMoreUpper: A password with an insufficient number of uppercase\nletters was supplied in an attempt to create a new user password.",
        "PasswordTooShort: A password of insufficient length was supplied in an attempt\nto create a new user password.",
        "PasswordTooSimilar: A password too similar to a previous password was supplied\nin an attempt to create a new user password.",
        "PermissionConflict: The requested operation is not possible due to a permission\nconflict with the resource.",
        "Unauthenticated: An unauthenticated request was made (i.e. invalid username\nand/or password).",
        "Unauthorized: An unauthorized request was made (i.e. user does not have\npermission to access the resource).",
        "SdkLicenseKeyEmpty: The SDK license key is empty.",
        "SdkLicenseKeyInvalid: The SDK license key data is invalid.",
        "SdkLicenseVersionInvalid: The license on the server does not support this\nversion of the SDK.",
        "SdkLicenseExpired: The license on the server has expired.",
        "SdkLicenseGracePeriodActive: The license associated with the license key was\nnot found on the server, but the license grace period is active.",
        "SdkLicenseGracePeriodExpire: The license associated with the license key was\nnot found on the server and the license grace period has expired."
    };
}