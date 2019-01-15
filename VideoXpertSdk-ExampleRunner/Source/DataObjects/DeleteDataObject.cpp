#include "stdafx.h"
#include "DeleteDataObject.h"
#include "Utility.h"

using namespace std;
using namespace VxSdk;
using namespace ExampleRunner::Common;

/// <summary>
/// Delete a selected dataObject from the current system.
/// </summary>
/// <param name="dataModel">Instance of data model.</param>
Plugin* ExampleRunner::DataObjects::DeleteDataObject::Run(DataModel* dataModel) {
    Utility::ClearScreen();

    // Read and print data objects from the system
    VxCollection<IVxDataObject**> dataObjects = GetDataObjects(dataModel->VxSystem);
    PrintDataObjects(dataObjects);

    if (dataObjects.collectionSize > 0) {
        // Select the data object to delete
        int index = SelectDataObjectIndex(dataObjects);
        if (index >= 0) {
            IVxDataObject* dataObject = dataObjects.collection[index];
            VxResult::Value result = dataObject->DeleteDataObject();
            if (result == VxResult::kOK)
                cout << "\n" << "DataObject deleted succesfully.\n";
            else
                cout << "\n" << "Failed to delete dataObject!!\n";
        }
    }

    // Remove the memory allocated to the collection.
    delete[] dataObjects.collection;
    // Wait for user response before going back to parent menu.
    Utility::Pause();

    // Return reference of parent plugin to move back to parent menu.
    return GetParent();
}

/// <summary>
/// Get a collection of dataObjects from the given VideoExpert system.
/// </summary>
/// <param name="vxSystem">Pointer to the VideoExpert system.</param>
/// <returns>A collection of dataObjects.</returns>
VxCollection<IVxDataObject**> ExampleRunner::DataObjects::DeleteDataObject::GetDataObjects(IVxSystem* vxSystem) {
    VxCollection<IVxDataObject**> dataObjects;
    VxResult::Value result = vxSystem->GetDataObjects(dataObjects);
    if (result == VxResult::kInsufficientSize) {
        dataObjects.collection = new IVxDataObject*[dataObjects.collectionSize];
        vxSystem->GetDataObjects(dataObjects);
    }
    return dataObjects;
}

/// <summary>
/// Prints the given collection of dataObjects to the screen.
/// </summary>
/// <param name="dataObjectCollection">Collection of dataObjects.</param>
void ExampleRunner::DataObjects::DeleteDataObject::PrintDataObjects(VxCollection<IVxDataObject**> dataObjectCollection) {
    cout << dataObjectCollection.collectionSize << " dataObjects found." << "\n";
    if (dataObjectCollection.collectionSize == 0)
        return;

    cout << "---------------------------------------------------------------------------------------------";
    for (int i = 0; i < dataObjectCollection.collectionSize; i++) {
        IVxDataObject* dataObject = dataObjectCollection.collection[i];

        cout << "\n" << (i + 1);
        cout << "\t" << dataObject->id;
        cout << "\t" << dataObject->owner;
        cout << "\t" << dataObject->clientType;
    }
    cout << "\n---------------------------------------------------------------------------------------------\n";
}

/// <summary>
/// Select a dataObject from the given collection by user input.
/// </summary>
/// <param name="dataObjects">Collection of dataObject.</param>
/// <returns>Index of the selected dataObject in the given collection.</returns>
int ExampleRunner::DataObjects::DeleteDataObject::SelectDataObjectIndex(VxCollection<IVxDataObject**> &dataObjects) {
    while (true) {
        cout << "\n" << "Enter dataObject number [1-" << dataObjects.collectionSize << "] : ";
        int index = Utility::ReadInt();
        if (index == 0)
            break;
        if (index > 0 && index <= dataObjects.collectionSize)
            return index - 1;
        else
            cout << "\n" << "Invalid Option !!!";

        cout << "\n" << "Enter 0 to go back.";
    }

    return -1;
}
