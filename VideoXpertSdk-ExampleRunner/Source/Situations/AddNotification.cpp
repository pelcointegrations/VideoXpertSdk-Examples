#include "stdafx.h"
#include "AddNotification.h"
#include "Utility.h"
#include <iomanip>

using namespace std;
using namespace VxSdk;
using namespace ExampleRunner::Common;

/// <summary>
/// Adds a notification to a situation.
/// </summary>
/// <param name="dataModel">Instance of data model.</param>
Plugin* ExampleRunner::Situations::AddNotification::Run(DataModel* dataModel) {
    Utility::ClearScreen();

    // Get all roles and situations from the system
    VxCollection<IVxRole**> roles = GetRoles(dataModel->VxSystem);
    VxCollection<IVxSituation**> situations = GetSituations(dataModel->VxSystem);

    // Display all situations and wait for user selection
    DisplaySituationDetailsOnScreen(situations);
    const int index = SelectSituationIndex(situations);

    Utility::ClearScreen();
    cout << "\n" << situations.collection[index]->name << " selected.  Choose roles to add for new notification:\n\n";

    // Get a list of selected roles from the user
    vector<string> roleIds = GetSelectedRoles(roles);

    // Create a notification object and populate its fields using newNotification
    VxNewNotification newNotification;
    newNotification.roleIdSize = static_cast<int>(roleIds.size());
    if (newNotification.roleIdSize > 0) {
        // Allocate memory for the role Ids
        newNotification.roleIds = new char*[newNotification.roleIdSize];
        for (int i = 0; i < newNotification.roleIdSize; i++) {
            string roleId = roleIds[i];
            newNotification.roleIds[i] = new char[static_cast<int>(roleId.size()) + 1];
            Utilities::StrCopySafe(newNotification.roleIds[i], roleId.c_str(), static_cast<int>(roleId.size()) + 1);
        }
    }

    // Make the call to add the notification to the situation
    IVxNotification* notificationItem = nullptr;
    const VxResult::Value result = situations.collection[index]->AddNotification(newNotification, notificationItem);
    if (result == VxResult::kOK)
        cout << "\n" << "Notification added succesfully.\n";
    else
        cout << "\n" << "Failed to add notification.\n";

    // Print the notification details if available
    if (notificationItem != nullptr) {
        PrintNotification(notificationItem, roles);
    }

    // Wait for user response before going back to parent menu
    Utility::Pause();

    // Remove the memory allocated to the collections
    delete[] situations.collection;
    delete[] roles.collection;

    // Return reference of parent plugin to move back to parent menu
    return GetParent();
}

/// <summary>
/// Print the given collection of situations to the screen.
/// </summary>
/// <param name="situations">Collection of situations to be printed.</param>
void ExampleRunner::Situations::AddNotification::DisplaySituationDetailsOnScreen(VxCollection<IVxSituation**> situations) {
    if (situations.collectionSize > 0) {
        cout << situations.collectionSize << " situations found.\n";

        // Print Heading
        cout << "\n\n";
        cout << setfill(' ') << "  INDEX         " << setw(60) << left << "  TYPE" << "\n";
        cout << "\n--------------------------------------------------\n";

        // Print Situation Details
        int index = 0;
        for (int i = 0; i < situations.collectionSize;i++) {
            IVxSituation* situation = situations.collection[i];
            cout << setfill(' ') << "\n\t" << index + 1 << "\t" << left << setw(60) << left << situation->type;
            index++;
        }
        // Print Footer
        cout << "\n--------------------------------------------------\n";
    }
    else
        cout << "No situations found!!\n";
}

/// <summary>
/// Get a collection of roles from the given VideoExpert system.
/// </summary>
/// <param name="vxSystem">Pointer to the VideoExpert system.</param>
/// <returns>A collection of roles.</returns>
VxCollection<IVxRole**> ExampleRunner::Situations::AddNotification::GetRoles(IVxSystem* vxSystem) {
    VxCollection<IVxRole**> roles;
    // Read the size of collection from system
    const VxResult::Value result = vxSystem->GetRoles(roles);
    if (result == VxResult::kInsufficientSize) {
        // Allocate memory for the requried collection
        roles.collection = new IVxRole*[roles.collectionSize];
        // Read the collection from system
        vxSystem->GetRoles(roles);
    }

    return roles;
}

/// <summary>
/// Get a list of roles selected by user input.
/// </summary>
/// <param name="roleCollection">Collection of roles.</param>
/// <returns>A list of selected roles.</returns>
vector<string> ExampleRunner::Situations::AddNotification::GetSelectedRoles(VxCollection<IVxRole**> roleCollection) {
    vector<string> selectedRoles;
    for (int i = 0; i < roleCollection.collectionSize; i++) {
        IVxRole* role = roleCollection.collection[i];

        if (role->isReadOnly && (strcmp(role->name, "administrator") != 0))
            continue;

        cout << "\n" << "Select role (" << role->name<< ") y/n : ";
        string option = Utility::ReadString();
        if (!option.empty() && (option[0] == 'y' || option[0] == 'Y')) {
            selectedRoles.emplace_back(role->id);
            cout << role->name << " is selected. \n";
        }
        else
            cout << role->name << " is NOT selected. \n";
    }

    return selectedRoles;
}

/// <summary>
/// Get a collection of situations from the given VideoExpert system.
/// </summary>
/// <param name="vxSystem">Pointer to the VideoExpert system.</param>
/// <returns>A collection of situations.</returns>
VxCollection<IVxSituation**> ExampleRunner::Situations::AddNotification::GetSituations(IVxSystem* vxSystem) {
    VxCollection<IVxSituation**> situations;
    // Read the size of collection from system
    const VxResult::Value result = vxSystem->GetSituations(situations);
    if (result == VxResult::kInsufficientSize) {
        // Allocate memory for the requried collection
        situations.collection = new IVxSituation*[situations.collectionSize];
        // Read the collection from system
        vxSystem->GetSituations(situations);
    }

    return situations;
}

/// <summary>
/// Prints the given notification to the screen.
/// </summary>
/// <param name="notification">The notification to print.</param>
/// <param name="roleCollection">Collection of roles.</param>
void ExampleRunner::Situations::AddNotification::PrintNotification(IVxNotification* notification, VxCollection<IVxRole**> roleCollection) {
    cout << "---------------------------------------------------------------------------------------------";
    cout << "\nID: " << notification->id;

    if (notification->roleIdSize > 0) {
        cout << "\nRole(s):";
        for (int j = 0; j < notification->roleIdSize; j++) {
            std::string roleName;
            for (int k = 0; k < roleCollection.collectionSize; k++) {
                if (strcmp(roleCollection.collection[k]->id, notification->roleIds[j]) == 0) {
                    roleName = roleCollection.collection[k]->name;
                    break;
                }
            }
            if (!roleName.empty()) {
                cout << "\n\t" << (j + 1) << ": " << roleName;
            }
            else {
                cout << "\n\t" << (j + 1) << ": " << notification->roleIds[j];
            }
        }
    }
    cout << "\n---------------------------------------------------------------------------------------------\n";
}

/// <summary>
/// Select a situation from the given collection by user input.
/// </summary>
/// <param name="situations">Collection of situations.</param>
/// <returns>Index of the selected situation in the given collection.</returns>
int ExampleRunner::Situations::AddNotification::SelectSituationIndex(VxCollection<IVxSituation**> &situations) {
    while (true) {
        // Select situation index
        cout << "\n" << "Enter situation index number [1-" << situations.collectionSize << "] : ";
        const int index = Utility::ReadInt();
        if (index == 0)
            break;

        // Verify user input
        if (index > 0 && index <= situations.collectionSize)
            return index - 1;

        cout << "\nInvalid Option !!!" << "\nEnter 0 to go back.";
    }

    return -1;
}
