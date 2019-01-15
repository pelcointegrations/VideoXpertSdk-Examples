#include "stdafx.h"
#include "Controller.h"
#include <iostream>
#include "Utility.h"
#include "Constants.h"
#ifdef WIN32
#include <conio.h>
#else
#include <curses.h>
#endif

using namespace std;
using namespace VxSdk;
using namespace ExampleRunner::Common;

/// <summary>
/// Run the selected plugin continously untill it gets a null reference from any plugin.
/// </summary>
/// <param name="licenseKey">The VxSDK license key.</param>
void Controller::Run(const char* licenseKey) {

    DataModel* dataModel = Initialize(licenseKey);
    if (dataModel == nullptr)
        return;

    // Set root as the default plugin
    _selectedPlugin = _root;

    // The main loop of the application.
    // Current plugin desides which should be the next plugin to execute.
    while (true) {

        _selectedPlugin = _selectedPlugin->Run(dataModel);

        // If any plugin returns null, the application exits.
        if (_selectedPlugin == nullptr)
            break;
    }
}

// This method initialize the VideoExpert system and
// Creates a new instance of DataModel.
DataModel* Controller::Initialize(const char* licenseKey) const {
    // Create Login information structure.
    VxLoginInfo loginInfo;
    loginInfo.port = Constants::kPortnum;
    loginInfo.useSsl = true;
    Utilities::StrCopySafe(loginInfo.licenseKey, licenseKey);

    cout << "\n" << "Enter system IP        : ";
    Utilities::StrCopySafe(loginInfo.ipAddress, Utility::ReadString().c_str());
    cout << "Enter system user name : ";
    Utilities::StrCopySafe(loginInfo.username, Utility::ReadString().c_str());
    cout << "Enter system password  : ";
    Utilities::StrCopySafe(loginInfo.password, Utility::ReadString().c_str());

    // Login to the VideoExpert system and get an instance of it.
    IVxSystem* vxSystem = nullptr;
    const VxResult::Value result = VxSystemLogin(loginInfo, vxSystem);

    Utility::ClearScreen();
    if (result == VxResult::kSdkLicenseGracePeriodActive) {
        const auto expireTime = Utility::ParseDateTime(vxSystem->graceLicenseExpirationTime);
        cout << "\nWARNING: This system has not been licensed to run this integration.\n";
        std::cout << "The grace period for this license is active but will expire: " << Utility::ConvertUTCtoLocalTime(expireTime);
        cout << "\nThis integration will cease to function if the system remains unlicensed when the grace period expires.\n\n";
        Utility::Pause();
    }
    else if (result != VxResult::kOK) {
        if (result == VxResult::kSdkLicenseGracePeriodExpired)
            cout << "\nERROR: This system has not been licensed to run this integration and the grace period has expired.\n\nA license for this integration must be activated on the system to proceed.\n\n";
        else
            cout << "\nERROR: Failed to login with error code: " << result << "\n\n";

        Utility::Pause(true);
        return nullptr;
    }

    // Create an instance of DataModel
    DataModel* dataModel = new DataModel();
    dataModel->VxSystem = vxSystem;
    dataModel->username = loginInfo.username;
    dataModel->password = loginInfo.password;

    return dataModel;
}
