#include "FilterExamples.h"
#include <iostream>
#include <string>
#include "Constants.h"

void FilterExamples::OptionSearchForDataSourcesUsingAdvancedQuery(IVxSystem* vxSystem) {
    ConsolePrinter consolePrinter;
    string searchValue;
    string choice;

    while (true) {
        ConsolePrinter::PrintMenuTitle("Search For DataSources Using An Advanced Query");
        if (!searchValue.empty()) {
            // Create the VxCollectionFilters that will be added to the data source collection
            VxCollectionFilter filters[1];

            filters->key = VxCollectionFilterItem::kAdvancedQuery;
            Utilities::StrCopySafe(filters->value,  searchValue.c_str());

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

        searchValue = "";
        bool queryLoop = true;
        while(queryLoop) {
            for (auto i : Options::kFieldOptions) {
                std::cout << i.displayText << "\n";
            }

            bool loop = true;
            while(loop) {
                cout << "\n\nSelect a field displayText to query [e(x)it]: ";
                choice = ConsolePrinter::ReadString();
                for (auto i : Options::kFieldOptions) {
                    if (choice == "x") {
                        return;
                    }

                    if (choice == i.choice) {
                        searchValue += "(" + i.value;
                        loop = false;
                    }
                }
            }

            const int optionsSize = choice == "1" ? 7 : 3;
            auto* options = new ConsolePrinter::SearchOption[optionsSize];
            for (int i = 0; i < optionsSize; i++) {
                options[i] = Options::kComparisonOptions[i];
                std::cout << options[i].displayText << "\n";
            }

            loop = true;
            while(loop) {
                cout << "\n\nSelect a comparison type to use in the query [e(x)it]: ";
                choice = ConsolePrinter::ReadString();
                for (int i = 0; i < optionsSize; i++) {
                    if (choice == "x") {
                        delete[] options;
                        return;
                    }

                    if (choice == options[i].choice) {
                        searchValue += options[i].value;
                        loop = false;
                    }
                }
            }

            choice = ConsolePrinter::GetUserValue("");
            if (choice == "x") {
                delete[] options;
                return;
            }

            searchValue += "'" + choice + "')";
            delete[] options;

            for (auto i : Options::kConnectiveOptions) {
                std::cout << i.displayText << "\n";
            }

            loop = true;
            while(loop) {
                cout << "\n\nSelect a connective operator to use in the query [e(x)it]: ";
                choice = ConsolePrinter::ReadString();
                for (auto i : Options::kConnectiveOptions) {
                    if (choice == "x") {
                        return;
                    }

                    if (choice == "3") {
                        loop = false;
                        queryLoop = false;
                        break;
                    }

                    if (choice == i.choice) {
                        searchValue += i.value;
                        loop = false;
                    }
                }
            }
        }
    }
}

void FilterExamples::OptionSearchForEventsUsingAdvancedQuery(IVxSystem* vxSystem) {
    ConsolePrinter consolePrinter;
    string searchValue;
    string choice;

    while (true) {
        ConsolePrinter::PrintMenuTitle("Search For Events Using An Advanced Query");
        if (!searchValue.empty()) {
            // Create the VxCollectionFilters that will be added to the event collection
            VxCollectionFilter filters[1];

            filters->key = VxCollectionFilterItem::kAdvancedQuery;
            Utilities::StrCopySafe(filters->value,  searchValue.c_str());

            // Initialize the event collection and add the filters to it
            VxCollection<IVxEvent**> eventCollection;
            eventCollection.filterSize = 1;
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

        searchValue = "";
        bool queryLoop = true;
        while(queryLoop) {
            for (auto i : Options::kEventFieldOptions) {
                std::cout << i.displayText << "\n";
            }

            bool loop = true;
            while(loop) {
                cout << "\n\nSelect a field displayText to query [e(x)it]: ";
                choice = ConsolePrinter::ReadString();
                for (auto i : Options::kEventFieldOptions) {
                    if (choice == "x") {
                        return;
                    }

                    if (choice == i.choice) {
                        searchValue += "(" + i.value;
                        loop = false;
                    }
                }
            }

            int optionsSize;
            if (choice == "10")
                optionsSize = 4;
            else if (choice == "9")
                optionsSize = 3;
            else
                optionsSize = 7;

            auto* options = new ConsolePrinter::SearchOption[optionsSize];
            if (choice == "10") {
                for (int i = 0; i < 7; i++) {
                    if (i < 3) continue;
                    options[i-3] = Options::kComparisonOptions[i];
                    std::cout << options[i-3].displayText << "\n";
                }
            }
            else {
                for (int i = 0; i < optionsSize; i++) {
                    options[i] = Options::kComparisonOptions[i];
                    std::cout << options[i].displayText << "\n";
                }
            }

            loop = true;
            while(loop) {
                cout << "\n\nSelect a comparison type to use in the query [e(x)it]: ";
                choice = ConsolePrinter::ReadString();
                for (int i = 0; i < optionsSize; i++) {
                    if (choice == "x") {
                        delete[] options;
                        return;
                    }

                    if (choice == options[i].choice) {
                        searchValue += options[i].value;
                        loop = false;
                    }
                }
            }

            choice = ConsolePrinter::GetUserValue("");
            if (choice == "x") {
                delete[] options;
                return;
            }

            searchValue += "'" + choice + "')";
            delete[] options;

            for (auto i : Options::kConnectiveOptions) {
                std::cout << i.displayText << "\n";
            }

            loop = true;
            while(loop) {
                cout << "\n\nSelect a connective operator to use in the query [e(x)it]: ";
                choice = ConsolePrinter::ReadString();
                for (auto i : Options::kConnectiveOptions) {
                    if (choice == "x") {
                        return;
                    }

                    if (choice == "3") {
                        loop = false;
                        queryLoop = false;
                        break;
                    }

                    if (choice == i.choice) {
                        searchValue += i.value;
                        loop = false;
                    }
                }
            }
        }
    }
}
