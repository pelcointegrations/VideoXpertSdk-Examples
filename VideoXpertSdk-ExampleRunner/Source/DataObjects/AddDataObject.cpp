#include "stdafx.h"
#include "AddDataObject.h"
#include "Utility.h"
#include <iomanip>

using namespace std;
using namespace VxSdk;
using namespace ExampleRunner::Common;

/// <summary>
/// Adds a dataObject to the current system.
/// </summary>
/// <param name="dataModel">Instance of data model.</param>
Plugin* ExampleRunner::DataObjects::AddDataObject::Run(DataModel* dataModel) {
    // Read clientType from input
    cout << "\n\n" << "Enter dataObject client type: ";
    string clientType = Utility::ReadString();

    // Read data from input
    cout << "\n\n" << "Enter data: ";
    string data = Utility::ReadString();

    // Add DataObject
    VxNewDataObject dataObject;
    dataObject.data = new char[static_cast<int>(data.size())+1]();
    Utilities::StrCopySafe(dataObject.clientType, clientType.c_str(), static_cast<int>(clientType.size())+1);
    Utilities::StrCopySafe(dataObject.data, data.c_str(), static_cast<int>(data.size())+1);

    // Make the call to add the dataObject into VideoXpert
    VxResult::Value result = dataModel->VxSystem->AddDataObject(dataObject);
    if (result == VxResult::kOK)
        cout << "\n" << "DataObject added succesfully.\n";
    else
        cout << "\n" << "Failed to add dataObject.\n";

    // Wait for user response before going back to parent menu.
    Utility::Pause();

    // Return reference of parent plugin to move back to parent menu.
    return GetParent();
}
