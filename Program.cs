using System;

namespace TodoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();
            bool exit = false;

            Console.WriteLine("Welcome to the To-Do List Application!");

            while (!exit)
            {
                Console.WriteLine("\nMENU OPTIONS:");
                Console.WriteLine("1. View Tasks");
                Console.WriteLine("2. Add Task");
                Console.WriteLine("3. Complete Task");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter your choice (1-4): ");

                // Fix for warning at line 23
                string? choice = Console.ReadLine();
                choice ??= string.Empty; // Provide empty string if null

                switch (choice)
                {
                    case "1":
                        taskManager.ViewTasks();
                        break;
                    case "2":
                        Console.Write("Enter task description: ");
                        // Fix for warnings at lines 32-33
                        string? description = Console.ReadLine();
                        if (!string.IsNullOrEmpty(description))
                        {
                            taskManager.AddTask(description);
                        }
                        else
                        {
                            Console.WriteLine("Task description cannot be empty.");
                        }
                        break;
                    case "3":
                        taskManager.ViewTasks();
                        Console.Write("Enter task number to complete: ");
                        string? taskNumberInput = Console.ReadLine();
                        if (int.TryParse(taskNumberInput, out int taskNumber))
                        {
                            taskManager.CompleteTask(taskNumber);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                        }
                        break;
                    case "4":
                        taskManager.SaveTasks();
                        exit = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}