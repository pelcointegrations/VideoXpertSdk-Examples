#include "stdafx.h"
#include "ViewNotifications.h"
#include "Utility.h"
#include <iomanip>

using namespace std;
using namespace VxSdk;
using namespace ExampleRunner::Common;

/// <summary>
/// Print all notifications available for a selected situation.
/// </summary>
/// <param name="dataModel">Instance of data model.</param>
Plugin* ExampleRunner::Situations::ViewNotifications::Run(DataModel* dataModel) {
    Utility::ClearScreen();

    // Get all roles and situations from the system
    VxCollection<IVxRole**> roles = GetRoles(dataModel->VxSystem);
    VxCollection<IVxSituation**> situations = GetSituations(dataModel->VxSystem);

    // Display all situations
    DisplaySituationDetailsOnScreen(situations);

    if (situations.collectionSize > 0) {
        // Get user selection
        const int index = SelectSituationIndex(situations);
        if (index >= 0) {
            // Display all notifications for the selected situation
            VxCollection<IVxNotification**> notifications = GetNotifications(situations.collection[index]);
            PrintNotifications(notifications, roles);
            delete[] notifications.collection;
        }
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
/// Print the given collection of situations on screen.
/// </summary>
/// <param name="situations">Collection of situations to be printed.</param>
void ExampleRunner::Situations::ViewNotifications::DisplaySituationDetailsOnScreen(VxCollection<IVxSituation**> situations) {

    if (situations.collectionSize > 0) {
        cout << situations.collectionSize << " situations found.\n";

        // Print heading
        cout << "\n\n";
        cout << setfill(' ') << "  INDEX         " << setw(60) << left << "  TYPE" << "\n";
        cout << "\n--------------------------------------------------\n";

        // Print situation Details
        int index = 0;
        for (int i = 0; i < situations.collectionSize;i++) {
            IVxSituation* situation = situations.collection[i];
            cout << setfill(' ') << "\n\t" << index + 1 << "\t" << left << setw(60) << left << situation->type;
            index++;
        }
        // Print footer
        cout << "\n--------------------------------------------------\n";
    }
    else
        cout << "No situations found!!\n";
}

/// <summary>
/// Get a collection of notifications from the given situation.
/// </summary>
/// <param name="situation">Pointer to the situation.</param>
/// <returns>A collection of notifications.</returns>
VxCollection<IVxNotification**> ExampleRunner::Situations::ViewNotifications::GetNotifications(IVxSituation* situation) {
    VxCollection<IVxNotification**> notifications;
    // Read the size of collection from system
    const VxResult::Value result = situation->GetNotifications(notifications);
    if (result == VxResult::kInsufficientSize) {
        // Allocate memory for the requried collection
        notifications.collection = new IVxNotification*[notifications.collectionSize];
        // Read the collection from system
        situation->GetNotifications(notifications);
    }

    return notifications;
}

/// <summary>
/// Get a collection of roles from the given VideoExpert system.
/// </summary>
/// <param name="vxSystem">Pointer to the VideoExpert system.</param>
/// <returns>A collection of roles.</returns>
VxCollection<IVxRole**> ExampleRunner::Situations::ViewNotifications::GetRoles(IVxSystem* vxSystem) {
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
/// Get a collection of situations from the given VideoExpert system.
/// </summary>
/// <param name="vxSystem">Pointer to the VideoExpert system.</param>
/// <returns>A collection of situations.</returns>
VxCollection<IVxSituation**> ExampleRunner::Situations::ViewNotifications::GetSituations(IVxSystem* vxSystem) {
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
/// Prints the given collection of notifications to the screen.
/// </summary>
/// <param name="notificationCollection">Collection of notifications.</param>
/// <param name="roleCollection">Collection of roles.</param>
void ExampleRunner::Situations::ViewNotifications::PrintNotifications(VxCollection<IVxNotification**> notificationCollection, VxCollection<IVxRole**> roleCollection) {
    Utility::ClearScreen();
    cout << notificationCollection.collectionSize << " notifications found." << "\n";
    if (notificationCollection.collectionSize == 0)
        return;

    cout << "---------------------------------------------------------------------------------------------";
    for (int i = 0; i < notificationCollection.collectionSize; i++) {
        IVxNotification* notification = notificationCollection.collection[i];

        cout << "\n" << (i + 1);
        cout << "\t" << notification->id;

        cout << "\t" << notification->roleIdSize << " role(s) associated with this.";
        for (int j = 0; j < notification->roleIdSize; j++) {
            std::string roleName;
            for (int k = 0; k < roleCollection.collectionSize; k++) {
                if (strcmp(roleCollection.collection[k]->id, notification->roleIds[j]) == 0) {
                    roleName = roleCollection.collection[k]->name;
                    break;
                }
            }
            if (!roleName.empty()) {
                cout << "\n\t\t" << (i + 1) << "." << (j + 1) << "\t" << roleName;
            }
            else {
                cout << "\n\t\t" << (i + 1) << "." << (j + 1) << "\t" << notification->roleIds[j];
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
int ExampleRunner::Situations::ViewNotifications::SelectSituationIndex(VxCollection<IVxSituation**> &situations) {
    while (true) {
        // Select situation index
        cout << "\n" << "Enter situation index number [1-" << situations.collectionSize << "] : ";
        const int index = Utility::ReadInt();
        if (index == 0)
            break;
        // Verify user input
        if (index > 0 && index <= situations.collectionSize)
            return index - 1;
        else
            cout << "\n" << "Invalid Option !!!";

        cout << "\n" << "Enter 0 to go back.";
    }

    return -1;
}
