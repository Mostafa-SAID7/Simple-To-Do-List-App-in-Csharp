using System;
using System.Collections.Generic;
using System.IO;

public class TodoTask
{
    public string Description { get; set; }
    public bool IsCompleted { get; set; }

    public override string ToString()
    {
        return $"{(IsCompleted ? "[x]" : "[ ]")} {Description}";
    }
}

class Program
{
    // List to store tasks
    static List<TodoTask> tasks = new List<TodoTask>();
    const string filePath = "tasks.txt";  // File to save tasks

    static void Main()
    {
        LoadTasks();  // Load existing tasks from the file when app starts
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("== TO-DO LIST ==");
            DisplayTasks();  // Display all tasks

            Console.WriteLine("\nOptions:");
            Console.WriteLine("1 - Add Task");
            Console.WriteLine("2 - Delete Task");
            Console.WriteLine("3 - Mark Task as Done");
            Console.WriteLine("4 - Exit");

            Console.Write("\nChoose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    DeleteTask();
                    break;
                case "3":
                    MarkTaskDone();
                    break;
                case "4":
                    SaveTasks();  // Save tasks to file before exiting
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Press Enter to continue...");
                    Console.ReadLine();
                    break;
            }
        }
    }

    // Display all tasks
    static void DisplayTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available.");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }

    // Add a new task
    static void AddTask()
    {
        Console.Write("Enter task description: ");
        string description = Console.ReadLine();
        tasks.Add(new TodoTask { Description = description, IsCompleted = false });
    }

    // Delete a task by its number
    static void DeleteTask()
    {
        Console.Write("Enter task number to delete: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= tasks.Count)
        {
            tasks.RemoveAt(index - 1);  // Remove task from list
        }
        else
        {
            Console.WriteLine("Invalid task number. Press Enter to continue...");
            Console.ReadLine();
        }
    }

    // Mark a task as done
    static void MarkTaskDone()
    {
        Console.Write("Enter task number to mark as done: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= tasks.Count)
        {
            tasks[index - 1].IsCompleted = true;
        }
        else
        {
            Console.WriteLine("Invalid task number. Press Enter to continue...");
            Console.ReadLine();
        }
    }

    // Save tasks to a file
    static void SaveTasks()
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var task in tasks)
            {
                writer.WriteLine($"{task.Description}|{task.IsCompleted}");
            }
        }
    }

    // Load tasks from a file
    static void LoadTasks()
    {
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 2)
                {
                    tasks.Add(new TodoTask
                    {
                        Description = parts[0],
                        IsCompleted = bool.Parse(parts[1])
                    });
                }
            }
        }
    }
}
