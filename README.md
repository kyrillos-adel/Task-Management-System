# Task Management System

## Overview
The Task Management System is a Windows Forms-based application designed to help users manage tasks efficiently. It provides a user-friendly interface for creating, updating, and managing tasks. The system supports features like drag-and-drop for task status changes, notifications for overdue tasks, task reporting, searching, and sorting. The application is built using WinForms, LINQ, Entity Framework, and MS SQL Server for data storage and management.

This project is part of the ITI Full Stack Web Development using .NET ICC program, specifically for the Database Course.

## Features
1. **Task Management**
   - **Create Tasks**: Add new tasks with details like title, description, due date, priority, and status.
   - **Update Tasks**: Modify existing task details.
   - **Delete Tasks**: Remove tasks that are no longer needed.

2. **Drag-and-Drop Task Status Update**
   - Easily change the status of tasks (e.g., from "To Do" to "In Progress" or "Completed") using drag-and-drop functionality.

3. **Overdue Task Notifications**
   - The system sends notifications for tasks that are overdue, ensuring users stay on top of their deadlines.

4. **Task Reporting**
   - Generate reports to view task statuses, including completed, in progress, and overdue tasks.

5. **Search and Sort Tasks**
   - **Search**: Quickly find tasks by title, description, or status.
   - **Sort**: Sort tasks by due date, priority, or status for better organization.

6. **Database Integration**
   - The application uses MS SQL Server for data storage and Entity Framework for seamless database operations.

## Technologies Used
- **Frontend**: Windows Forms (WinForms)
- **Backend**: C#, LINQ, Entity Framework
- **Database**: MS SQL Server
- **Other Tools**: Drag-and-Drop functionality, Notification System, Reporting

## Installation and Setup

### Prerequisites
- **.NET Framework**: Ensure you have the .NET Framework installed.
- **MS SQL Server**: Install and configure MS SQL Server on your machine.
- **Visual Studio**: Recommended IDE for running and modifying the project.

### Steps to Run the Project
1. **Clone the Repository**:
   - Download or clone the repository from GitHub:
   ```sh
git clone https://github.com/kyrillos-adel/Task-Management-System.git```

2. **Open the Project**:
   - Open the solution file (`TaskManagementSystem.sln`) in Visual Studio.
3. **Set Up the Database**:
   - Run the SQL script provided in the `Database` folder to create the necessary database and tables.
   - Update the connection string in the `App.config` file to point to your SQL Server instance.
4. **Build and Run**:
   - Build the project in Visual Studio and run it.

## How to Use
- **Create a Task**:
  - Click on the "Add Task" button.
  - Fill in the task details (title, description, due date, priority, and status).
  - Save the task.
- **Update Task Status**:
  - Drag and drop tasks between different status columns (e.g., "To Do", "In Progress", "Completed").
- **View Overdue Tasks**:
  - Overdue tasks will be highlighted, and notifications will be displayed.
- **Generate Reports**:
  - Navigate to the "Reports" section to view task status reports.
- **Search and Sort**:
  - Use the search bar to find specific tasks.
  - Sort tasks by clicking on the column headers (e.g., due date, priority).

## Contributing
Contributions are welcome! If you'd like to contribute to this project, please follow these steps:
1. Fork the repository.
2. Create a new branch for your feature or bugfix.
3. Commit your changes.
4. Push your branch and submit a pull request.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact
For any questions or feedback, feel free to reach out:
- **Author**: Kyrillos Adel
- **Email**: [kyrillosadelfahim@gmail.com]
- **GitHub**: [kyrillos-adel](https://github.com/kyrillos-adel)
