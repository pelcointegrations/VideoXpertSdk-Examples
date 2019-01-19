#pragma once
#include <vector>
#include <VxSdk.h>

using namespace VxSdk;
using namespace std;

typedef void (*option_method_pointer)(IVxSystem* vxSystem);

/// <summary>
/// A utility class that provides methods for reading console input and printing formatted console output.
/// </summary>
class ConsolePrinter {
public:
    /// <summary>
    /// Represents a column within the table output.
    /// </summary>
    struct Column {
    public:
        /// <summary>
        /// The header text for the column.
        /// </summary>
        std::string headerText;

        /// <summary>
        /// The column width.
        /// </summary>
        int width{};
    };

    /// <summary>
    /// Represents a selectable main menu option.
    /// </summary>
    struct MenuOption {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="choice">The value that will be entered by the user to select an option.</param>
        /// <param name="displayText">The text that will be displayed to the user for this choice.</param>
        /// <param name="optionMethod">The function that will be called when this option is selected.</param>
        MenuOption(const char* choice, const char* displayText, const option_method_pointer optionMethod) : choice(choice), displayText(displayText), optionMethod(optionMethod) { }

        /// <summary>
        /// The value that will be entered by the user to select an option.
        /// </summary>
        std::string choice;

        /// <summary>
        /// The text that will be displayed to the user for this choice.
        /// </summary>
        const char* displayText = "";

        /// <summary>
        /// The function that will be called when this option is selected.
        /// </summary>
        option_method_pointer optionMethod;
    };

    /// <summary>
    /// Represents a selectable menu option.
    /// </summary>
    struct SearchOption {
        /// <summary>
        /// Default constructor.
        /// </summary>
        SearchOption() = default;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="choice">The value that will be entered by the user to select an option.</param>
        /// <param name="displayText">The text that will be displayed to the user for this choice.</param>
        /// <param name="value">The associated value that the choice represents.</param>
        SearchOption(const char* choice, const char* displayText, const char* value) : choice(choice), displayText(displayText), value(value) { }

        /// <summary>
        /// The value that will be entered by the user to select an option.
        /// </summary>
        std::string choice;

        /// <summary>
        /// The text that will be displayed to the user for this choice.
        /// </summary>
        const char* displayText = "";

        /// <summary>
        /// The associated value that the choice represents.
        /// </summary>
        std::string value;
    };

    /// <summary>
    /// Represents a row within the table output.
    /// </summary>
    struct Row {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="isNoMatch"><c>true</c> sets the row to print that no matches were found.</param>
        explicit Row(const bool isNoMatchRow = false) : isNoMatchRow(isNoMatchRow) { }

        /// <summary>
        /// <c>true</c> sets the row to print that no matches were found.
        /// </summary>
        bool isNoMatchRow;

        /// <summary>
        /// The values contained within the row.
        /// </summary>
        std::vector<std::string> values;
    };

    /// <summary>
    /// Create an instance of ConsolePrinter class.
    /// </summary>
    ConsolePrinter() noexcept: _columns(std::vector<Column*>()), _rows(std::vector<Row*>()) { }

    /// <summary>
    /// Destructor.
    /// </summary>
    ~ConsolePrinter() = default;

    /// <summary>
    /// Add a string value to the current cell in the table and forward the pointer to next cell.
    /// </summary>
    /// <param name="value">New string value to be added.</param>
    void AddCellValue(const std::string& value);

    /// <summary>
    /// Add an integer value to the current cell in the table and forward the pointer to next cell.
    /// </summary>
    /// <param name="value">New int value to be added.</param>
    void AddCellValue(int value);

    /// <summary>
    /// Add a column to the table.
    /// </summary>
    /// <param name="heading">Heading of the column.</param>
    /// <param name="width">Width of the column.</param>
    void AddColumn(std::string heading, int width);

    /// <summary>
    /// Add a row to the table.
    /// </summary>
    /// <param name="isNoMatch"><c>true</c> sets the row to print that no matches were found.</param>
    void AddRow(bool isNoMatch = false);

    /// <summary>
    /// Prompts the user for a search value and returns the result.
    /// If no value is entered, the <paramref name="previousValue"/> will be returned.
    /// </summary>
    /// <param name="previousValue">The previous value entered by the user.</param>
    /// <returns> The value entered by the user.</returns>
    static std::string GetUserValue(const std::string& previousValue);

    /// <summary>
    /// Prompts the user for a boolean value and returns the formatted result.
    /// </summary>
    /// <param name="promptText">The text to display in the prompt.</param>
    /// <returns> The boolean value entered by the user.</returns>
    static std::string GetUserValueBool(const std::string& promptText);

    /// <summary>
    /// Prints a menu title.
    /// </summary>
    /// <param name="title">The title of the menu.</param>
    static void PrintMenuTitle(const std::string& title);

    /// <summary>
    /// Convert the VxCollection results to a table and print it.
    /// </summary>
    /// <param name="dataSourceCollection">The data source collection returned from the search.</param>
    void PrintResultTable(VxCollection<IVxDataSource**> dataSourceCollection);

    /// <summary>
    /// Convert the VxCollection results to a table and print it.
    /// </summary>
    /// <param name="deviceCollection">The device collection returned from the search.</param>
    void PrintResultTable(VxCollection<IVxDevice**> deviceCollection);

    /// <summary>
    /// Convert the VxCollection results to a table and print it.
    /// </summary>
    /// <param name="eventCollection">The event collection returned from the search.</param>
    void PrintResultTable(VxCollection<IVxEvent**> eventCollection);

    /// <summary>
    /// Reads the raw value entered into the console by the user.
    /// </summary>
    /// <returns> The value entered by the user.</returns>
    static std::string ReadString();

    /// <summary>
    /// Prompts and Waits for the user to continue.
    /// </summary>
    static void WaitForUser();

private:
    /// <summary>
    /// The columns for the current table.
    /// </summary>
    std::vector<Column*> _columns;

    /// <summary>
    /// The rows for the current table.
    /// </summary>
    std::vector<Row*> _rows;

    /// <summary>
    /// The length of the string in the header row.
    /// </summary>
    int _rowLength = 0;

    /// <summary>
    /// Creates the header row based on the added columns.
    /// </summary>
    /// <returns> The header row as a formatted string.</returns>
    std::string BuildHeaderRow();

    /// <summary>
    /// Creates a standard row based on the added columns.
    /// </summary>
    /// <param name="row">The row to build.</param>
    /// <returns> The row as a formatted string.</returns>
    std::string BuildRow(Row* row);

    /// <summary>
    /// Formats the value of a cell based on the width of the column.
    /// </summary>
    /// <param name="cellValue">The cell value.</param>
    /// <param name="column">The column of the cell.</param>
    /// <returns> The cell as a formatted string.</returns>
    static std::string FormatCellValue(const std::string& cellValue, Column* column);

    /// <summary>
    /// Prints the current table string to the console.
    /// </summary>
    void PrintTable();
};
