#include "stdafx.h"
#include "DeleteSituation.h"
#include "Utility.h"
#include <iomanip>

using namespace std;
using namespace VxSdk;
using namespace ExampleRunner::Common;

// Delete a particular situation specified by user from the current system.
Plugin* ExampleRunner::Situations::DeleteSituation::Run(DataModel* dataModel) {
    Delete(dataModel->VxSystem);

    // Pause for user input before going back to parent menu.
    // Wait for user response before going back to parent menu.
    Utility::Pause();

    // Return reference of parent plugin to move back to parent menu.
    return GetParent();
}

/// <summary>
/// Menu function for deleting situation from server
/// </summary>
/// <param name="vxSystem">system pointer</param>
void ExampleRunner::Situations::DeleteSituation::Delete(IVxSystem* vxSystem) {
    // Get all situations from the system
    cout << "\n" << "Fetching situations from system..Please wait..\n";
    VxCollection<IVxSituation**> situations = GetSituations(vxSystem);
    DisplaySituationDetailsOnScreen(situations);

    // User selects a situation
    cout << "\n" << "Enter the index of situation to delete [1-" << situations.collectionSize << "] : ";
    int situationToDelete = Utility::ReadInt();

    // Validate user input
    if (situationToDelete < 1 || situationToDelete > situations.collectionSize)
        return;

    // Print details of selected situation to delete
    IVxSituation* situation = situations.collection[situationToDelete - 1];
    cout << "\n" << "Situation selected for delete is:" << situation->type << "\n";

    // Delete the situation
    VxResult::Value result = situation->DeleteSituation();
    if (result == VxResult::kOK)
        cout << "\n" << "Situation deleted succesfully.\n";
    else
        cout << "\n" << "Failed to delete situation.\n";

    // Remove the memory allocated to the collection.
    delete[] situations.collection;
}

// Get a collection of situations from the given VideoExpert system.
VxCollection<IVxSituation**> ExampleRunner::Situations::DeleteSituation::GetSituations(IVxSystem* vxSystem) {
    // Read the size of collection from system.
    VxCollection<IVxSituation**> situations;
    VxResult::Value result = vxSystem->GetSituations(situations);
    if (result == VxResult::kInsufficientSize) {
        // Allocate memory for the requried collection.
        situations.collection = new IVxSituation*[situations.collectionSize];
        // Read the collection from system.
        result = vxSystem->GetSituations(situations);
    }

    return situations;
}

/// <summary>
/// Print the given collection of situations on screen.
/// </summary>
/// <param name="situations">Situations list to iterate</param>
void ExampleRunner::Situations::DeleteSituation::DisplaySituationDetailsOnScreen(VxCollection<IVxSituation**> situations) {
    if (situations.collectionSize > 0) {
        cout << situations.collectionSize << " situations found.\n";

        cout << "\n\n";
        cout << setfill(' ') << "  INDEX         " << setw(60) << left << "  TYPE" << "\n";
        cout << "\n--------------------------------------------------\n";

        int index = 0;
        for (int i = 0; i < situations.collectionSize; i++) {
            IVxSituation* situation = situations.collection[i];
            cout << setfill(' ') << "\n\t" << index + 1 << "\t" << left << setw(60) << left << situation->type;
            index++;
        }
        cout << "\n--------------------------------------------------\n";
    }
    else
        cout << "No situations found!!\n";
}
