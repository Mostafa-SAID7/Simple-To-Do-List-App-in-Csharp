Simple To-Do List App in C#
A simple console-based To-Do List application built in C# that allows users to manage their tasks. This app enables users to add tasks, mark them as completed, delete tasks, and save/load tasks from a file. It's a great beginner project for learning basic concepts in C#, including file I/O, collections, methods, and control flow.

Features
Add, view, delete, and mark tasks as done
Tasks are saved to and loaded from a text file
Handles task management in a simple, user-friendly interface
Easy-to-understand code structure for beginners

Technologies Used
* C#
* Console Application
* File I/O (StreamReader, StreamWriter)

How to Use

1. Clone the Repository
To get started, clone this repository to your local machine:
```csharp
git clone https://github.com/your-username/simple-todo-app-csharp.git
cd simple-todo-app-csharp ```

2. Run the Application
After cloning the repo, you can run the application using the .NET CLI:
```csharp
dotnet run ```

The app will open in the console, and you'll be able to perform the following actions:

Add Task: Enter a task description to add a new task.
Delete Task: Select a task to delete by its number.
Mark Task as Done: Select a task to mark as completed.
Exit: Exit the app, and your tasks will be saved automatically.

3. Save and Load Tasks
Tasks are saved in a text file (tasks.txt) in the project directory. When you restart the application, your tasks will be loaded from this file.

Example
```csharp
== TO-DO LIST ==
1. [ ] Buy groceries
2. [x] Finish homework

Options:
1 - Add Task
2 - Delete Task
3 - Mark Task as Done
4 - Exit ```

How the App Works
Display Tasks: The app will show a list of tasks, each marked as either completed or pending.
Add Task: You can add a new task by providing a description.
Delete Task: You can delete a task by its task number.
Mark Task Done: You can mark tasks as completed.
File I/O: All tasks are saved to a file (tasks.txt) when you exit the app and are loaded back when you start the app again.

Contributing
Feel free to fork the project and submit pull requests. If you have any suggestions or improvements, don't hesitate to contribute!

License
This project is open-source and available under the MIT License.
