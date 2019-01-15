#include "stdafx.h"
#include "AddSituation.h"
#include "Utility.h"
#include <iomanip>

using namespace std;
using namespace VxSdk;
using namespace ExampleRunner::Common;

/// <summary>
/// Adds a situation to the current system.
/// </summary>
/// <param name="dataModel">Instance of data model.</param>
Plugin* ExampleRunner::Situations::AddSituation::Run(DataModel* dataModel) {

    AddNewSituation(dataModel->VxSystem);

    // Return reference of parent plugin to move back to parent menu.
    return GetParent();
}

/// <summary>
/// Add a new situation to server.
/// </summary>
/// <param name="vxSystem">Pointer to the VideoExpert system.</param>
void ExampleRunner::Situations::AddSituation::AddNewSituation(IVxSystem* vxSystem) {

    cout << "\n\n" << "Enter name for situation: ";
    string sitName = Utility::ReadString();

    cout << "\n" << "Enter type for situation (in format: 'external/{company_name}/{situation_type}'): ";
    string sitType = Utility::ReadString();

    VxNewSituation situation;
    situation.Default();
#ifndef WIN32
    strncpy(situation.name, sitName.c_str(), sizeof situation.name);
    strncpy(situation.type, sitType.c_str(), sizeof situation.type);
#else
    strncpy_s(situation.name, sitName.c_str(), sizeof situation.name);
    strncpy_s(situation.type, sitType.c_str(), sizeof situation.type);
#endif

    VxResult::Value result = vxSystem->AddSituation(situation);
    if (result == VxResult::kOK)
        cout << "\n" << "Situation added succesfully.\n";
    else
        cout << "\n" << "Failed to add situation.\n";

    // Remove the memory allocated to the collection.
    delete[] situation.snoozeIntervals;

    // Wait for user response before going back to parent menu.
    Utility::Pause();
}
