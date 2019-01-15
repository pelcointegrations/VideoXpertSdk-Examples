#include "stdafx.h"
#include <iomanip>
#include "AddTriggerToSchedule.h"
#include "Utility.h"
#include "OptionSelector.h"

using namespace std;
using namespace VxSdk;
using namespace ExampleRunner::Common;

/// <summary>
/// Creates a trigger and add it to a selected schedule in the current system.
/// </summary>
/// <param name="dataModel">Instance of data model.</param>
Plugin* ExampleRunner::Schedules::AddTriggerToSchedule::Run(DataModel* dataModel) {
    cout << "\n";
    VxCollection<IVxSchedule**> schedules = GetSchedules(dataModel->VxSystem);
    OptionSelector<IVxSchedule*> optionSelector;
    optionSelector.Heading = "Select a schedule to add trigger";
    for (int i = 0; i < schedules.collectionSize; i++) {
        IVxSchedule* schedule = schedules.collection[i];
        string name = schedule->id + string("\t") + schedule->name;
        optionSelector.AddItem(name, schedule);
    }

    IVxSchedule* selectedSchedule = nullptr;
    if (optionSelector.SelectOption(&selectedSchedule)) {

        // Create a new schedule trigger
        VxNewScheduleTrigger scheduleTrigger;
        string newGuid = Utility::GetNewGuid();
        Utilities::StrCopySafe(scheduleTrigger.id, newGuid.c_str());

        cout << "\n";

        // Framerate
        OptionSelector<VxRecordingFramerate::Value> framerateSelector;
        framerateSelector.Heading = "Select a type of frame rate";
        framerateSelector.AddItem("Log", VxRecordingFramerate::kLow);
        framerateSelector.AddItem("Normal", VxRecordingFramerate::kNormal);
        if (!framerateSelector.SelectOption(&scheduleTrigger.framerate))
            scheduleTrigger.framerate = VxRecordingFramerate::kUnknown;

        // Event 
        cout << "\n";
        VxCollection<IVxSituation**> situations = GetSituations(dataModel->VxSystem);
        OptionSelector<string> eventSelector;
        eventSelector.Heading = "\nSelect a type of event";
        for (int i = 0; i < situations.collectionSize; i++) {
            IVxSituation* situation = situations.collection[i];
            string name = situation->type;
            eventSelector.AddItem(name, name);
        }

        string selectedType;
        if (eventSelector.SelectOption(&selectedType))
            Utilities::StrCopySafe(scheduleTrigger.eventSituationType, selectedType.c_str());

        // PreTrigger
        cout << "\n" << "Enter PreTrigger value      : ";
        scheduleTrigger.preTrigger = Utility::ReadInt();

        // PostTrigger
        cout << "Enter PostTrigger value     : ";
        scheduleTrigger.postTrigger = Utility::ReadInt();

        // Timeout
        cout << "Enter Timeout Duration      : ";
        scheduleTrigger.timeout = Utility::ReadInt();

        // Make the call to add the schedule into VideoXpert
        VxResult::Value result = selectedSchedule->AddScheduleTrigger(scheduleTrigger);
        if (result == VxResult::kOK)
            cout << "\n" << "Schedule added succesfully.\n";
        else
            cout << "\n" << "Failed to add schedule.\n";
    }

    // Wait for user response before going back to parent menu.
    Utility::Pause();

    // Return reference of parent plugin to move back to parent menu.
    return GetParent();
}

/// <summary>
/// Get a collection of schedules from the given VideoExpert system.
/// </summary>
/// <param name="vxSystem">Pointer to the VideoExpert system.</param>
/// <returns>A collection of schedules.</returns>
VxCollection<IVxSchedule**> ExampleRunner::Schedules::AddTriggerToSchedule::GetSchedules(IVxSystem* vxSystem) {
    VxCollection<IVxSchedule**> schedules;
    VxResult::Value result = vxSystem->GetSchedules(schedules);
    if (result == VxResult::kInsufficientSize) {
        schedules.collection = new IVxSchedule*[schedules.collectionSize];
        vxSystem->GetSchedules(schedules);
    }
    return schedules;
}

/// <summary>
/// Get a collection of situations from the given VideoExpert system.
/// </summary>
/// <param name="vxSystem">Pointer to the VideoExpert system.</param>
/// <returns>A collection of situations.</returns>
VxCollection<IVxSituation**> ExampleRunner::Schedules::AddTriggerToSchedule::GetSituations(IVxSystem* vxSystem) {
    VxCollection<IVxSituation**> situations;
    VxResult::Value result = vxSystem->GetSituations(situations);
    if (result == VxResult::kInsufficientSize) {
        situations.collection = new IVxSituation*[situations.collectionSize];
        vxSystem->GetSituations(situations);
    }
    return situations;
}
