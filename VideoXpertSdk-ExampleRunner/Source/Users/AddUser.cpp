#include "stdafx.h"
#include "AddUser.h"
#include "Utility.h"
#include <iomanip>

using namespace std;
using namespace VxSdk;
using namespace ExampleRunner::Common;

/// <summary>
/// Adds a user to the current system.
/// </summary>
/// <param name="dataModel">Instance of data model.</param>
Plugin* ExampleRunner::Users::AddUser::Run(DataModel* dataModel) {
    // Read domain from input
    cout << "\n\n" << "Enter user domain   : ";
    string domain = Utility::ReadString();

    // Read name from input
    cout << "Enter user name     : ";
    string name = Utility::ReadString();

    // Read password from input
    cout << "Enter user password : ";
    string password = Utility::ReadString();

    // Add User
    VxNewUser vxNewUser;
    Utilities::StrCopySafe(vxNewUser.domain, domain.c_str());
    Utilities::StrCopySafe(vxNewUser.name, name.c_str());
    Utilities::StrCopySafe(vxNewUser.password, password.c_str());
    vxNewUser.mustChangePassword = false;

    // Make the call to add the user into VideoXpert
    VxResult::Value result = dataModel->VxSystem->AddUser(vxNewUser);
    if (result == VxResult::kOK)
        cout << "\n" << "User added succesfully.\n";
    else
        cout << "\n" << "Failed to add user.\n";

    // Wait for user response before going back to parent menu.
    Utility::Pause();

    // Return reference of parent plugin to move back to parent menu.
    return GetParent();
}
