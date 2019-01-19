#include "FilterExamples.h"
#include <iostream>
#include "Constants.h"

void FilterExamples::OptionSearchDataSourcesMultiFilter(IVxSystem* vxSystem) {
    ConsolePrinter consolePrinter;
    string isCapturing;
    string isRecording;
    string isOnline;

    while (true) {
        ConsolePrinter::PrintMenuTitle("Search For DataSources Using Multiple Filters");
        if (!isCapturing.empty()) {
            // Create the VxCollectionFilters that will be added to the data source collection
            VxCollectionFilter filters[3];

            filters[0].key = VxCollectionFilterItem::kCapturing;
            Utilities::StrCopySafe(filters[0].value, isCapturing.c_str());

            filters[1].key = VxCollectionFilterItem::kRecording;
            Utilities::StrCopySafe(filters[1].value, isRecording.c_str());

            filters[2].key = VxCollectionFilterItem::kState;
            string state = isOnline == "true" ? "online" : "offline";
            Utilities::StrCopySafe(filters[2].value, state.c_str());

            // Initialize the data source collection and add the filters to it
            VxCollection<IVxDataSource**> dataSourceCollection;
            dataSourceCollection.filterSize = 3;
            dataSourceCollection.filters = filters;

            // Call GetDataSources using the filters contained within the data source collection
            VxResult::Value result = vxSystem->GetDataSources(dataSourceCollection);
            if (result == VxResult::kInsufficientSize) {
                dataSourceCollection.collection = new IVxDataSource*[dataSourceCollection.collectionSize];
                result = vxSystem->GetDataSources(dataSourceCollection);
                if (result != VxResult::kOK) {
                    std::cout << "Error " << PrintValues::kErrorStrings[result] << "\n\n";
                    ConsolePrinter::WaitForUser();
                    return;
                }
            }

            consolePrinter.PrintResultTable(dataSourceCollection);
        }

        isCapturing = ConsolePrinter::GetUserValueBool("Is DataSource Capturing?");
        if (isCapturing == "x")
            return;

        isRecording = ConsolePrinter::GetUserValueBool("Is DataSource Recording?");
        if (isRecording == "x")
            return;

        isOnline = ConsolePrinter::GetUserValueBool("Is DataSource Online?");
        if (isOnline == "x")
            return;
    }
}

void FilterExamples::OptionSearchEventsMultiFilter(IVxSystem* vxSystem) {
    ConsolePrinter consolePrinter;
    string searchStartTime;
    string searchEndTime;

    while (true) {
        ConsolePrinter::PrintMenuTitle("Search For Events Using Multiple Filters");
        if (!searchStartTime.empty()) {
            // Create the VxCollectionFilters that will be added to the event collection
            VxCollectionFilter filters[2];

            filters[0].key = VxCollectionFilterItem::kSearchStartTime;
            Utilities::StrCopySafe(filters[0].value, searchStartTime.c_str());

            filters[1].key = VxCollectionFilterItem::kSearchEndTime;
            Utilities::StrCopySafe(filters[1].value, searchEndTime.c_str());


            // Initialize the event collection and add the filters to it
            VxCollection<IVxEvent**> eventCollection;
            eventCollection.filterSize = 2;
            eventCollection.filters = filters;

            // Call GetEvents using the filters contained within the event collection
            VxResult::Value result = vxSystem->GetEvents(eventCollection);
            if (result == VxResult::kInsufficientSize) {
                eventCollection.collection = new IVxEvent*[eventCollection.collectionSize];
                result = vxSystem->GetEvents(eventCollection);
                if (result != VxResult::kOK) {
                    std::cout << "Error " << PrintValues::kErrorStrings[result] << "\n\n";
                    ConsolePrinter::WaitForUser();
                    return;
                }
            }

            consolePrinter.PrintResultTable(eventCollection);
        }

        std::cout << "\n\nSearch Start Time (yyyy-MM-ddTHH:mm:ss.fffZ) [e(x)it]: ";
        searchStartTime = ConsolePrinter::ReadString();
        if (searchStartTime == "x")
            return;

        std::cout << "\n\nSearch End Time (yyyy-MM-ddTHH:mm:ss.fffZ) [e(x)it]: ";
        searchEndTime = ConsolePrinter::ReadString();
        if (searchEndTime == "x")
            return;
    }
}
