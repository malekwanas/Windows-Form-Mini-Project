# ABC Company Annual Revenue Application

## Overview
This application displays the annual revenue data of ABC Company in a user-friendly interface. It includes a table on the right side and a customizable chart on the left side. Users can interact with the chart using keyboard shortcuts, mouse clicks, and menu options.

## Features

### 1. Application Header
- Displays the company name: "ABC Company" at the top middle of the application.
- Shows the report title: "Annual Revenue" below the company name.

### 2. Table
- Presents the company's revenue data in a table on the right side of the application.

### 3. Chart
- Displays a chart with the x-axis representing years and the y-axis representing revenue.
- Provides both Bar and Line charts.
- Initial chart settings: Blue solid line for the Line chart and red left diagonal hatch for the Bar chart.

### 4. Keyboard Shortcuts
- **Ctrl + R**: Change the Line chart color to Red.
- **Ctrl + G**: Change the Line chart color to Green.
- **Ctrl + B**: Change the Line chart color to Blue.

### 5. Mouse Interaction
- Left-click on any point in the chart to display a message box with the corresponding revenue value and year.
- No response for a left-click outside the chart area.

### 6. Menus
#### Line Menu
- Submenu: Color (Red, Green, Blue)
- Submenu: Style (Solid, Dash, Dotted)

#### Rectangle Menu
- Submenu: Color (Red, Green, Blue)
- Submenu: Style (Right, Left, Cross)

### 7. Right-Click Functionality
- Right-click in the chart region invokes the Rectangle menu.
- Right-click outside the chart region invokes the Line menu.

### 8. Toolbar
- Allows users to change the color and style of both Line and Rectangle charts.

### 9. Status Bar
- Displays the Year and Revenue when moving the mouse in the chart area.

### 10. Format Menu
- Submenu: Company Name opens a dialog box with the following options:
  - Font (Times New Roman, Arial, Courier)
  - Size (16, 20, 24)
  - Color (opens a Color Dialog Box)
  - Text (two text boxes for old and new values)

## Usage

1. Launch the application.
2. Interact with the chart using keyboard shortcuts, mouse clicks, and menus.
3. Utilize the Format menu to customize the appearance of the Company Name.

Enjoy exploring ABC Company's annual revenue data in a visually appealing and interactive environment!

---

*Note: This README provides an overview of the features and usage instructions. For detailed implementation, refer to the source code.*
