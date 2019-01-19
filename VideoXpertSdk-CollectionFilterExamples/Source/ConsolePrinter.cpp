#include <string>
#include <iostream>
#include <utility>
#include "Constants.h"
#include "FilterExamples.h"

using namespace std;

void ConsolePrinter::AddCellValue(const string& value) {
    Row *currentRow = _rows.back();
    
    if (static_cast<int>(currentRow->values.size()) < _columns.size())
        currentRow->values.push_back(value);
}

void ConsolePrinter::AddCellValue(const int value) {
    AddCellValue(to_string(value));
}

void ConsolePrinter::AddColumn(string heading, const int width) {
    auto* columnHeading = new Column();
    columnHeading->headerText = std::move(heading);
    columnHeading->width = width;
    _columns.push_back(columnHeading);
}

void ConsolePrinter::AddRow(const bool isNoMatch) {
    auto* tempRow = new Row();
    tempRow->isNoMatchRow = isNoMatch;
    _rows.push_back(tempRow);
}

string ConsolePrinter::BuildHeaderRow() {
    string rowValue;
    const auto colCount = static_cast<int>(_columns.size());
    for (int i = 0; i < colCount; i++)
        rowValue += FormatCellValue(_columns[i]->headerText, _columns[i]);

    _rowLength = rowValue.size();
    const string dashLine = string(_rowLength, '-');
    return dashLine + "\n" + rowValue + "\n" + dashLine + "\n";
}

string ConsolePrinter::BuildRow(Row* row) {
    if (row->isNoMatchRow)
        return "No Matches";

    string rowValue;
    const auto colCount = static_cast<int>(row->values.size());
    for (int i = 0; i < colCount; i++)
        rowValue += FormatCellValue(row->values[i], _columns[i]);

    return rowValue;
}

string ConsolePrinter::FormatCellValue(const string& cellValue, Column* column) {
    string alignedCellValue;
    const int colWidth = column->width;
    const auto currentWidth = static_cast<int>(cellValue.size());
    if (currentWidth > colWidth) {
        alignedCellValue = cellValue.substr(0, colWidth);
    }
    else {
        const int spacing = colWidth - currentWidth;
        alignedCellValue = cellValue + string(spacing, ' ');
    }

    return alignedCellValue;
}

std::string ConsolePrinter::GetUserValue(const std::string& previousValue) {
    std::cout << "\n\nEnter a search value [e(x)it]: ";
    std::string userValue = ReadString();
    if (userValue.empty())
        userValue = previousValue;

    return userValue;
}

std::string ConsolePrinter::GetUserValueBool(const std::string& promptText) {
    std::cout << "\n\n" << promptText << " [(t)rue/(f)alse/e(x)it]: ";
    const std::string userValue = ReadString();
    if (userValue == "x")
        return userValue;
    
    if (userValue == "t" || userValue == "T" || userValue == "true" || userValue == "True" || userValue == "TRUE")
        return "true";

    return "false";
}

void ConsolePrinter::PrintMenuTitle(const std::string& title) {
    system("cls");

    std::cout << "\n ";
    std::cout << title;
    std::cout << "\n================================================\n\n";
}

void ConsolePrinter::PrintTable() {
    string tableString = BuildHeaderRow();

    const auto rowCount = static_cast<int>(_rows.size());
    for (int i = 0; i < rowCount; i++)
        tableString += BuildRow(_rows[i]) + "\n";

    tableString += string(_rowLength, '-') + "\n\n";

    _rows.clear();
    _columns.clear();
    _rowLength = 0;

    cout << tableString;
}

void ConsolePrinter::PrintResultTable(VxCollection<IVxDataSource**> dataSourceCollection) {
    int defaultColumnSize = 7;
    for (int i = 0; i < dataSourceCollection.filterSize; i++)
        if (strlen(dataSourceCollection.filters[i].value) > defaultColumnSize)
            defaultColumnSize = strlen(dataSourceCollection.filters[i].value);

    AddColumn("Key", 27);
    AddColumn("Value", defaultColumnSize);
    for (int i = 0; i < dataSourceCollection.filterSize; i++) {
        AddRow();
        AddCellValue(PrintValues::kFilterItemStrings[dataSourceCollection.filters[i].key]);
        AddCellValue(dataSourceCollection.filters[i].value);
    }

    PrintTable();

    cout << dataSourceCollection.collectionSize << " result(s) found";
    if (dataSourceCollection.collectionSize > kMaxResults)
        cout << ". Showing first " << kMaxResults;

    cout << ":\n";

    AddColumn("#", 5);
    AddColumn("Name", 30);
    AddColumn("ID", 50);
    AddColumn("IP", 16);
    AddColumn("Recording", 10);
    AddColumn("Type", 8);
    if (dataSourceCollection.collectionSize != 0)
    {
        for (int i = 0; i < dataSourceCollection.collectionSize; i++) {
            if (i == kMaxResults) break;
            IVxDataSource* dataSource = dataSourceCollection.collection[i];

            AddRow();
            AddCellValue(dataSource->number);
            AddCellValue(dataSource->name);
            AddCellValue(dataSource->id);
            AddCellValue(dataSource->ip);
            AddCellValue(dataSource->isRecording ? "True " : "False");
            AddCellValue( PrintValues::kDataSourceTypeStrings[dataSource->type]);
        }
    }
    else {
        AddRow(true);
    }

    PrintTable();
}

void ConsolePrinter::PrintResultTable(VxCollection<IVxDevice**> deviceCollection) {
    int defaultColumnSize = 7;
    for (int i = 0; i < deviceCollection.filterSize; i++)
        if (strlen(deviceCollection.filters[i].value) > defaultColumnSize)
            defaultColumnSize = strlen(deviceCollection.filters[i].value);

    AddColumn("Key", 27);
    AddColumn("Value", defaultColumnSize);
    for (int i = 0; i < deviceCollection.filterSize; i++) {
        AddRow();
        AddCellValue(PrintValues::kFilterItemStrings[deviceCollection.filters[i].key]);
        AddCellValue(deviceCollection.filters[i].value);
    }

    PrintTable();

    cout << deviceCollection.collectionSize << " result(s) found";
    if (deviceCollection.collectionSize > kMaxResults)
        cout << ". Showing first " << kMaxResults;

    cout << ":\n";

    AddColumn("Name", 30);
    AddColumn("ID", 50);
    AddColumn("IP", 16);
    AddColumn("Type", 16);
    AddColumn("State", 8);
    if (deviceCollection.collectionSize != 0)
    {
        for (int i = 0; i < deviceCollection.collectionSize; i++) {
            if (i == kMaxResults) break;
            IVxDevice* device = deviceCollection.collection[i];

            AddRow();
            AddCellValue(device->name);
            AddCellValue(device->id);
            AddCellValue(device->ip);
            AddCellValue(PrintValues::kDeviceTypeStrings[device->type]);
            AddCellValue(PrintValues::kDeviceStatusStrings[device->state]);
        }
    }
    else {
        AddRow(true);
    }

    PrintTable();
}

void ConsolePrinter::PrintResultTable(VxCollection<IVxEvent**> eventCollection) {
    int defaultColumnSize = 7;
    for (int i = 0; i < eventCollection.filterSize; i++)
        if (strlen(eventCollection.filters[i].value) > defaultColumnSize)
            defaultColumnSize = strlen(eventCollection.filters[i].value);

    AddColumn("Key", 27);
    AddColumn("Value", defaultColumnSize);
    for (int i = 0; i < eventCollection.filterSize; i++) {
        AddRow();
        AddCellValue(PrintValues::kFilterItemStrings[eventCollection.filters[i].key]);
        AddCellValue(eventCollection.filters[i].value);
    }

    PrintTable();

    cout << eventCollection.collectionSize << " result(s) found";
    if (eventCollection.collectionSize > kMaxResults)
        cout << ". Showing first " << kMaxResults;

    cout << ":\n";

    AddColumn("Time", 25);
    AddColumn("Situation Type", 35);
    AddColumn("ID", 37);
    AddColumn("Sev", 5);
    AddColumn("Ack State", 14);
    if (eventCollection.collectionSize != 0)
    {
        for (int i = 0; i < eventCollection.collectionSize; i++) {
            if (i == kMaxResults) break;
            IVxEvent* vxEvent = eventCollection.collection[i];

            AddRow();
            AddCellValue(vxEvent->time);
            AddCellValue(vxEvent->situationType);
            AddCellValue(vxEvent->id);
            AddCellValue(vxEvent->severity);
            AddCellValue(PrintValues::kAckStateStrings[vxEvent->ackState]);
        }
    }
    else {
        AddRow(true);
    }

    PrintTable();
}

std::string ConsolePrinter::ReadString() {
    std::string line;
    getline(std::cin, line);
    return line;
}

void ConsolePrinter::WaitForUser() {
    std::cout << "\n\nPress Enter to continue...";

    std::cin.clear();
    fseek(stdin, 0, SEEK_END);
    fflush(stdin);
    while (std::cin.get() != '\n');
}
