#include "stdafx.h"
#include "AddTag.h"
#include "Utility.h"
#include <iomanip>

using namespace std;
using namespace VxSdk;
using namespace ExampleRunner::Common;

/// <summary>
/// Adds a tag to the current system.
/// </summary>
/// <param name="dataModel">Instance of data model.</param>
Plugin* ExampleRunner::Tags::AddTag::Run(DataModel* dataModel) {

    // Read name from input
    cout << "\n\n" << "Enter tag name: ";
    string name = Utility::ReadString();

    cout << "\n\n" << "Create tag as folder y/n: ";
    string option = Utility::ReadString();
    bool isFolder = false;
    if (!option.empty() && (option[0] == 'y' || option[0] == 'Y'))
        isFolder = true;

    bool isPublic = false;
    if (!isFolder) {
        cout << "\n\n" << "Create public tag y/n: ";
        string option2 = Utility::ReadString();
        if (!option2.empty() && (option2[0] == 'y' || option2[0] == 'Y'))
            isPublic = true;
    }

    string parentId;
    cout << "\n\n" << "Assign a parent tag y/n: ";
    string option2 = Utility::ReadString();
    if (!option2.empty() && (option2[0] == 'y' || option2[0] == 'Y')) {
        // Get a collection of tags
        VxCollection<IVxTag**> tags = GetTags(dataModel->VxSystem);
        PrintTags(tags);
        if (tags.collectionSize > 0) {
            int index = SelectTagIndex(tags);
            if (index >= 0) {
                parentId = tags.collection[index]->id;
            }
        }

        // Remove the memory allocated to the collection.
        delete[] tags.collection;
    }

    // Add Tag
    VxNewTag tag;
    Utilities::StrCopySafe(tag.name, name.c_str());
    tag.isFolder = isFolder;
    tag.isPublic = isPublic;
    if (!parentId.empty())
        Utilities::StrCopySafe(tag.parentId, parentId.c_str());

    // Make the call to add the tag into VideoXpert
    VxResult::Value result = dataModel->VxSystem->AddTag(tag);
    if (result == VxResult::kOK)
        cout << "\n" << "Tag added succesfully.\n";
    else
        cout << "\n" << "Failed to add tag.\n";

    // Wait for user response before going back to parent menu.
    Utility::Pause();

    // Return reference of parent plugin to move back to parent menu.
    return GetParent();
}

/// <summary>
/// Prints the given collection of tags to the screen.
/// </summary>
/// <param name="tagCollection">Collection of tags.</param>
void ExampleRunner::Tags::AddTag::PrintTags(VxCollection<IVxTag**> tagCollection) {
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
/// Get a collection of tags from the given VideoExpert system.
/// </summary>
/// <param name="vxSystem">Pointer to the VideoExpert system.</param>
/// <returns>A collection of tags.</returns>
VxCollection<IVxTag**> ExampleRunner::Tags::AddTag::GetTags(IVxSystem* vxSystem) {
    VxCollection<IVxTag**> tags;
    VxResult::Value result = vxSystem->GetTags(tags);
    if (result == VxResult::kInsufficientSize) {
        tags.collection = new IVxTag*[tags.collectionSize];
        vxSystem->GetTags(tags);
    }
    return tags;
}

/// <summary>
/// Select a tag from the given collection by user input.
/// </summary>
/// <param name="tags">Collection of tag.</param>
/// <returns>Index of the selected tag in the given collection.</returns>
int ExampleRunner::Tags::AddTag::SelectTagIndex(VxCollection<IVxTag**> &tags) {
    while (true) {
        cout << "\n" << "Enter tag number [1-" << tags.collectionSize << "] : ";
        int index = Utility::ReadInt();
        if (index == 0)
            break;
        if (index > 0 && index <= tags.collectionSize)
            return index - 1;
        else
            cout << "\n" << "Invalid Option !!!";

        cout << "\n" << "Enter 0 to go back.";
    }

    return -1;
}
