#include "stdafx.h"
#include "ViewAllTags.h"
#include "Utility.h"
#include <vector>
#include <iomanip>

using namespace std;
using namespace VxSdk;
using namespace ExampleRunner::Common;

/// <summary>
/// Print all tags available in the current system.
/// </summary>
/// <param name="dataModel">Instance of data model.</param>
Plugin* ExampleRunner::Tags::ViewAllTags::Run(DataModel* dataModel) {
    Utility::ClearScreen();

    // Get a collection of tags
    VxCollection<IVxTag**> tags = GetTags(dataModel->VxSystem);
    PrintTags(tags);

    // Wait for user response before going back to parent menu.
    Utility::Pause();

    // Remove the memory allocated to the collection.
    delete[] tags.collection;
    // Return reference of parent plugin to move back to parent menu.
    return GetParent();
}

/// <summary>
/// Get a collection of tags from the given VideoExpert system.
/// </summary>
/// <param name="vxSystem">Pointer to the VideoExpert system.</param>
/// <returns>A collection of tags.</returns>
VxCollection<IVxTag**> ExampleRunner::Tags::ViewAllTags::GetTags(IVxSystem* vxSystem) {
    VxCollection<IVxTag**> tags;
    VxResult::Value result = vxSystem->GetTags(tags);
    if (result == VxResult::kInsufficientSize) {
        tags.collection = new IVxTag*[tags.collectionSize];
        vxSystem->GetTags(tags);
    }
    return tags;
}

/// <summary>
/// Prints the given collection of tags to the screen.
/// </summary>
/// <param name="tagCollection">Collection of tags.</param>
void ExampleRunner::Tags::ViewAllTags::PrintTags(VxCollection<IVxTag**> tagCollection) {
    cout << tagCollection.collectionSize << " tags found." << "\n";
    if (tagCollection.collectionSize == 0)
        return;
    
    cout << setfill(' ') << setw(6) << left << "INDEX" << setw(40) << left << "ID" << setw(16) << left << "NAME" << setw(8) << left << "FOLDER" << "PARENT" << "\n";
    cout << "------------------------------------------------------------------------------------------------------------";
    for (int i = 0; i < tagCollection.collectionSize; i++) {
        IVxTag* tag = tagCollection.collection[i];
        cout << "\n" << setw(6) << left << (i + 1);
        cout << setw(40) << left <<  tag->id;
        cout << setw(16) << left <<  tag->name;
        cout << setw(8) << left;
        if (tag->isFolder)
            cout << "Y";
        else
            cout << "N";

        cout << tag->parentId;
    }
    cout << "\n------------------------------------------------------------------------------------------------------------\n";
}
