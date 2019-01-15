#include "stdafx.h"
#include "MergeTag.h"
#include "Utility.h"
#include <iomanip>

using namespace std;
using namespace VxSdk;
using namespace ExampleRunner::Common;

/// <summary>
/// Merge two tags in the current system.
/// </summary>
/// <param name="dataModel">Instance of data model.</param>
Plugin* ExampleRunner::Tags::MergeTag::Run(DataModel* dataModel) {
    Utility::ClearScreen();

    // Get a collection of tags
    VxCollection<IVxTag**> tags = GetTags(dataModel->VxSystem);
    PrintTags(tags);

    if (tags.collectionSize > 0) {
        int firstIndex = SelectTagIndex(tags, -1);
        int secondIndex = SelectTagIndex(tags, firstIndex);
        if (firstIndex < 0 || firstIndex >= tags.collectionSize ||
            secondIndex < 0 || secondIndex >= tags.collectionSize) {
            cout << "\n" << "Invalid input.\n";
        } else {
            IVxTag* firstTag = tags.collection[firstIndex];
            IVxTag* secondTag = tags.collection[secondIndex];
            VxResult::Value result = firstTag->Merge(*secondTag);
            if (result == VxResult::kOK)
                cout << "\n" << "Tag merged succesfully.\n";
            else
                cout << "\n" << "Failed to merge tag!!\n";

            // Remove the memory allocated to the collection.
            delete[] tags.collection;
        }
    }

    // Wait for user response before going back to parent menu.
    Utility::Pause();

    // Return reference of parent plugin to move back to parent menu.
    return GetParent();
}

/// <summary>
/// Get a collection of tags from the given VideoExpert system.
/// </summary>
/// <param name="vxSystem">Pointer to the VideoExpert system.</param>
/// <returns>A collection of tags.</returns>
VxCollection<IVxTag**> ExampleRunner::Tags::MergeTag::GetTags(IVxSystem* vxSystem) {
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
void ExampleRunner::Tags::MergeTag::PrintTags(VxCollection<IVxTag**> tagCollection) {
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

/// <summary>
/// Select a tag from the given collection by user input.
/// </summary>
/// <param name="tags">Collection of tag.</param>
/// <param name="firstIndex">Provide -1 to select first index.</param>
/// <returns>Index of the selected tag in the given collection.</returns>
int ExampleRunner::Tags::MergeTag::SelectTagIndex(VxCollection<IVxTag**> &tags, int firstIndex) {
    while (true) {
        if (firstIndex < 0)
            cout << "\n" << "Enter first tag number [1-" << tags.collectionSize << "] : ";
        else
            cout << "\n" << "Enter second tag number [1-" << tags.collectionSize << "] : ";
        int index = Utility::ReadInt();
        if (index == 0)
            break;
        if (index > 0 && index <= tags.collectionSize) {
            if (index - 1 == firstIndex)
                cout << "\n" << "First and second tags must be different.";
            else
                return index - 1;
        }
        else
            cout << "\n" << "Invalid Option !!!";

        cout << "\n" << "Enter 0 to go back.";
    }

    return -1;
}
