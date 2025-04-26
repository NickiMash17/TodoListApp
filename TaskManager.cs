using System;
using System.Collections.Generic;
using System.IO;

namespace TodoListApp
{
    public class TaskManager
    {
        private List<Task> tasks;
        private const string FILE_PATH = "tasks.txt";

        public TaskManager()
        {
            tasks = new List<Task>();
            LoadTasks();
        }

        public void AddTask(string description)
        {
            tasks.Add(new Task(description));
            Console.WriteLine("Task added successfully!");
        }

        public void ViewTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            Console.WriteLine("\nTASK LIST:");
            Console.WriteLine("----------");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
            Console.WriteLine();
        }

        public void CompleteTask(int taskNumber)
        {
            if (taskNumber < 1 || taskNumber > tasks.Count)
            {
                Console.WriteLine("Invalid task number!");
                return;
            }

            tasks[taskNumber - 1].IsCompleted = true;
            Console.WriteLine("Task marked as completed!");
        }

        public void SaveTasks()
        {
            using (StreamWriter writer = new StreamWriter(FILE_PATH))
            {
                foreach (var task in tasks)
                {
                    writer.WriteLine($"{task.Description},{task.IsCompleted}");
                }
            }
            Console.WriteLine("Tasks saved successfully!");
        }

        private void LoadTasks()
        {
            if (!File.Exists(FILE_PATH))
                return;

            string[] lines = File.ReadAllLines(FILE_PATH);
            foreach (var line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 2)
                {
                    Task task = new Task(parts[0]);
                    task.IsCompleted = bool.Parse(parts[1]);
                    tasks.Add(task);
                }
            }
        }
    }
}