#include <iostream>
#include "FilterExamples.h"
#include "Constants.h"

static const char* kLicenseKey = "ENTER_LICENSE_KEY_HERE";

// These values can be set in order to skip the manual login prompt.
static const char* kSystemIp = "";
static const char* kUserName = "";
static const char* kPassword = "";

IVxSystem* Login() {
    ConsolePrinter::PrintMenuTitle("System Login");
    // Create Login information structure.
    VxLoginInfo loginInfo;
    loginInfo.port = 443;
    loginInfo.useSsl = true;
    Utilities::StrCopySafe(loginInfo.licenseKey, kLicenseKey);

    if ((strcmp(kSystemIp, "") != 0) && (strcmp(kUserName, "") != 0) && (strcmp(kPassword, "") != 0)) {
        std::cout << "Connecting to " << kSystemIp << ".\n\n";
        Utilities::StrCopySafe(loginInfo.ipAddress, kSystemIp);
        Utilities::StrCopySafe(loginInfo.username, kUserName);
        Utilities::StrCopySafe(loginInfo.password, kPassword);
    }
    else {
        cout << Messages::kEnterIp;
        Utilities::StrCopySafe(loginInfo.ipAddress, ConsolePrinter::ReadString().c_str());
        cout << Messages::kEnterName;
        Utilities::StrCopySafe(loginInfo.username, ConsolePrinter::ReadString().c_str());
        cout << Messages::kEnterPassword;
        Utilities::StrCopySafe(loginInfo.password, ConsolePrinter::ReadString().c_str());
    }

    // Login to the VideoExpert system and get an instance of it.
    IVxSystem* vxSystem = nullptr;
    const VxResult::Value result = VxSystemLogin(loginInfo, vxSystem);

    if (result != VxResult::kOK && result != VxResult::kSdkLicenseGracePeriodActive) {
        printf(Messages::kLoginError, PrintValues::kErrorStrings[result]);
        if (vxSystem != nullptr) {
            vxSystem->Delete();
            vxSystem = nullptr;
        }

        ConsolePrinter::WaitForUser();
    }

    return vxSystem;
}

int main() {
    // Provide a warning if the license key has not been set.
    if (strcmp(kLicenseKey, "ENTER_LICENSE_KEY_HERE") == 0) {
        std::cout << Messages::kDefaultKeyError;
        ConsolePrinter::WaitForUser();
        return -1;
    }

    // Set the SDK log level to trace in order to see the requests and responses in the log output.
    VxSetLogLevel(VxLogLevel::kTrace);

    // Attempt to create and log in to the IVxSystem.
    IVxSystem* vxSystem = nullptr;
    while (vxSystem == nullptr) {
        vxSystem = Login();
    }

    // Display the main menu options to the user.
    while (true) {
        ConsolePrinter::PrintMenuTitle("Main Menu");
        if (vxSystem->graceLicenseExpirationTime[0] != '\0') {
            printf(Messages::kLicenseWarning, vxSystem->graceLicenseExpirationTime);
        }

        for (auto i : Options::kMainMenu) {
            std::cout << i.displayText << "\n";
        }

        cout << "\n\nEnter selection: ";
        const string choice = ConsolePrinter::ReadString();
        for (auto i : Options::kMainMenu) {
            if (choice == "0") {
                vxSystem->Delete();
                vxSystem = nullptr;
                return 0;
            }

            if (choice == i.choice) {
                const option_method_pointer pFunction = i.optionMethod;
                (pFunction)(vxSystem);
            }
        }
    }
}
