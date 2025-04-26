// ╔════════════════════════════════════════════════════════╗
// ║                  TodoListApp - Program.cs               ║
// ║         Simple C# Console Application for Tasks         ║
// ╚════════════════════════════════════════════════════════╝

using System;

namespace TodoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();
            bool exit = false;

            // ╔═══════════════════════════════════════╗
            // ║      Welcome Message                  ║
            // ╚═══════════════════════════════════════╝
            Console.WriteLine("╔═══════════════════════════════════════╗");
            Console.WriteLine("║  Welcome to the To-Do List Manager!   ║");
            Console.WriteLine("╚═══════════════════════════════════════╝");

            while (!exit)
            {
                // 📋 Display Menu
                Console.WriteLine("\n📋 MENU OPTIONS:");
                Console.WriteLine("  1. 👁️  View Tasks");
                Console.WriteLine("  2. ➕ Add Task");
                Console.WriteLine("  3. ✓  Complete Task");
                Console.WriteLine("  4. 🚪 Exit");
                Console.Write("\nEnter your choice (1-4): ");

                string? choice = Console.ReadLine();
                choice ??= string.Empty;

                // 🎯 Handle User Choice
                switch (choice)
                {
                    case "1":
                        taskManager.ViewTasks();
                        break;

                    case "2":
                        Console.Write("Enter task description: ");
                        string? description = Console.ReadLine();
                        if (!string.IsNullOrEmpty(description))
                        {
                            taskManager.AddTask(description);
                        }
                        else
                        {
                            Console.WriteLine("⚠️ Task description cannot be empty.");
                        }
                        break;

                    case "3":
                        taskManager.ViewTasks();
                        Console.Write("Enter task number to complete: ");
                        if (int.TryParse(Console.ReadLine(), out int taskNumber))
                        {
                            taskManager.CompleteTask(taskNumber);
                        }
                        else
                        {
                            Console.WriteLine("⚠️ Invalid input. Please enter a number.");
                        }
                        break;

                    case "4":
                        taskManager.SaveTasks();
                        exit = true;
                        Console.WriteLine("Goodbye! See you next time. 👋");
                        break;

                    default:
                        Console.WriteLine("⚠️ Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
