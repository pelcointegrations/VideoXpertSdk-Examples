#include "FilterExamples.h"
#include <iostream>
#include "Constants.h"

void FilterExamples::OptionSearchForDataSourceByNumber(IVxSystem* vxSystem) {
    ConsolePrinter consolePrinter;
    string searchValue;

    while (true) {
        ConsolePrinter::PrintMenuTitle("Search For DataSource By Number");
        if (!searchValue.empty()) {
            // Create the VxCollectionFilters that will be added to the data source collection
            VxCollectionFilter filters[1];

            filters[0].key = VxCollectionFilterItem::kNumber;
            Utilities::StrCopySafe(filters[0].value, searchValue.c_str());

            // Initialize the data source collection and add the filters to it
            VxCollection<IVxDataSource**> dataSourceCollection;
            dataSourceCollection.filterSize = 1;
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

        searchValue = ConsolePrinter::GetUserValue(searchValue);
        if (searchValue == "x")
            return;
    }
}

void FilterExamples::OptionSearchForDevicesByIp(IVxSystem* vxSystem) {
    ConsolePrinter consolePrinter;
    string searchValue;

    while (true) {
        ConsolePrinter::PrintMenuTitle("Search For Device(s) By IP");
        if (!searchValue.empty()) {
            // Create the VxCollectionFilters that will be added to the device collection
            VxCollectionFilter filters[1];

            filters[0].key = VxCollectionFilterItem::kIp;
            Utilities::StrCopySafe(filters[0].value, searchValue.c_str());

            // Initialize the device collection and add the filters to it
            VxCollection<IVxDevice**> deviceCollection;
            deviceCollection.filterSize = 1;
            deviceCollection.filters = filters;

            // Call GetDevices using the filters contained within the device collection
            VxResult::Value result = vxSystem->GetDevices(deviceCollection);
            if (result == VxResult::kInsufficientSize) {
                deviceCollection.collection = new IVxDevice*[deviceCollection.collectionSize];
                result = vxSystem->GetDevices(deviceCollection);
                if (result != VxResult::kOK) {
                    std::cout << "Error " << PrintValues::kErrorStrings[result] << "\n\n";
                    ConsolePrinter::WaitForUser();
                    return;
                }
            }

            consolePrinter.PrintResultTable(deviceCollection);
        }

        searchValue = ConsolePrinter::GetUserValue(searchValue);
        if (searchValue == "x")
            return;
    }
}
