#include "stdafx.h"
#include "DeleteNotification.h"
#include "Utility.h"
#include <iomanip>

using namespace std;
using namespace VxSdk;
using namespace ExampleRunner::Common;

/// <summary>
/// Delete a notification from a situation.
/// </summary>
/// <param name="dataModel">Instance of data model.</param>
Plugin* ExampleRunner::Situations::DeleteNotification::Run(DataModel* dataModel) {
    Utility::ClearScreen();

    // Get all roles and situations from the system
    VxCollection<IVxRole**> roles = GetRoles(dataModel->VxSystem);
    VxCollection<IVxSituation**> situations = GetSituations(dataModel->VxSystem);

    // Display all situations and wait for user selection
    DisplaySituationDetailsOnScreen(situations);
    const int sitIndex = SelectSituationIndex(situations);

    Utility::ClearScreen();
    cout << "\n" << situations.collection[sitIndex]->name << " selected.  Choose notification to delete:\n\n";

    // Get and display all notifications for the selected situation
    VxCollection<IVxNotification**> notifications = GetNotifications(situations.collection[sitIndex]);
    PrintNotifications(notifications, roles);

    if (notifications.collectionSize > 0) {
        // Get user selection
        const int notIndex = SelectNotificationIndex(notifications);
        if (notIndex >= 0) {
            // Get the selected notification and delete it from the situation
            IVxNotification* notification = notifications.collection[notIndex];
            const VxResult::Value result = notification->DeleteNotification();
            if (result == VxResult::kOK)
                cout << "\n" << "Notification deleted succesfully.\n";
            else
                cout << "\n" << "Failed to delete notification!!\n";
        }
    }

    // Remove the memory allocated to the collections
    delete[] notifications.collection;
    delete[] situations.collection;
    delete[] roles.collection;

    // Wait for user response before going back to parent menu
    Utility::Pause();

    // Return reference of parent plugin to move back to parent menu
    return GetParent();
}

/// <summary>
/// Print the given collection of situations on screen.
/// </summary>
/// <param name="situations">Collection of situations to be printed.</param>
void ExampleRunner::Situations::DeleteNotification::DisplaySituationDetailsOnScreen(VxCollection<IVxSituation**> situations) {

    if (situations.collectionSize > 0) {
        cout << situations.collectionSize << " situations found.\n";

        // Print heading
        cout << "\n\n";
        cout << setfill(' ') << "  INDEX         " << setw(60) << left << "  TYPE" << "\n";
        cout << "\n--------------------------------------------------\n";

        // Print situation details
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
VxCollection<IVxNotification**> ExampleRunner::Situations::DeleteNotification::GetNotifications(IVxSituation* situation) {
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
VxCollection<IVxRole**> ExampleRunner::Situations::DeleteNotification::GetRoles(IVxSystem* vxSystem) {
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
VxCollection<IVxSituation**> ExampleRunner::Situations::DeleteNotification::GetSituations(IVxSystem* vxSystem) {
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
void ExampleRunner::Situations::DeleteNotification::PrintNotifications(VxCollection<IVxNotification**> notificationCollection, VxCollection<IVxRole**> roleCollection) {
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
/// Select a notification from the given collection by user input.
/// </summary>
/// <param name="notifications">Collection of notification.</param>
/// <returns>Index of the selected notification in the given collection.</returns>
int ExampleRunner::Situations::DeleteNotification::SelectNotificationIndex(VxCollection<IVxNotification**> &notifications) {
    while (true) {
        // Select notification number
        cout << "\n" << "Enter notification number [1-" << notifications.collectionSize << "] : ";
        const int index = Utility::ReadInt();
        if (index == 0)
            break;
        // Verify user input
        if (index > 0 && index <= notifications.collectionSize)
            return index - 1;
        else
            cout << "\n" << "Invalid Option !!!";

        cout << "\n" << "Enter 0 to go back.";
    }

    return -1;
}

/// <summary>
/// Select a situation from the given collection by user input.
/// </summary>
/// <param name="situations">Collection of situations.</param>
/// <returns>Index of the selected situation in the given collection.</returns>
int ExampleRunner::Situations::DeleteNotification::SelectSituationIndex(VxCollection<IVxSituation**> &situations) {
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
