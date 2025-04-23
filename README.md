# 📝 To-Do List Application

[![.NET](https://img.shields.io/badge/.NET-%20v6.0+-blueviolet.svg)](https://dotnet.microsoft.com/en-us/)
[![License](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![Maintenance](https://img.shields.io/badge/Maintained%3F-yes-green.svg)](https://github.com/NickiMash17/TodoListApp/graphs/commit-activity)
[![GitHub issues](https://img.shields.io/github/issues/NickiMash17/TodoListApp.svg)](https://github.com/NickiMash17/TodoListApp/issues/)

A simple, console-based To-Do List application built with **C#** and **.NET**. This project allows users to manage tasks by adding, viewing, completing, and saving them to a file. It demonstrates core C# programming concepts such as object-oriented design, collections, file I/O, and user input handling.

---

## ✨ Features

- **Add Tasks:** Create new tasks with a description.
- **View Tasks:** Display all tasks with their completion status (completed or pending).
- **Complete Tasks:** Mark tasks as completed by their task number.
- **Persistent Storage:** Tasks are saved to a file (`tasks.txt`) and loaded automatically on startup.
- **User-Friendly Interface:** Menu-driven console interface for easy navigation.

---

## 🖼️ Screenshots

![Application Main Menu](/api/placeholder/800/400)
*Main menu of the To-Do List application*

![Adding a Task](/api/placeholder/800/400)
*Adding a new task to the list*

![Viewing Tasks](/api/placeholder/800/400)
*Viewing all tasks with their status*

> Note: Replace placeholder images with actual screenshots of your application.

---

## 🛠 Technologies Used

- **Language:** C#
- **Framework:** .NET (compatible with .NET 6 or later)
- **IDE:** Visual Studio 2022 (or any C# compatible IDE)
- **File I/O:** Text file handling for data persistence

---

## 🚀 Getting Started

### ✅ Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/en-us/download) (version 6.0 or later)
- [Visual Studio](https://visualstudio.microsoft.com/) (optional, for development)
- [Git](https://git-scm.com/) (to clone the repository)

---

### 📥 Installation

1. **Clone the repository:**

```bash
git clone https://github.com/NickiMash17/TodoListApp.git
cd TodoListApp
```

2. **Open the Project:**
   * Using Visual Studio: Open `TodoListApp.sln`
   * Or navigate to the project directory in your terminal

3. **Run the Application:**
   * In Visual Studio: Press `F5` or click `Start`
   * In terminal: Run

```bash
dotnet run
```

---

## 🧭 Usage

Once launched, use the menu to perform the following actions:

* **View Tasks:** Display all tasks in the list
* **Add Task:** Add a new task by providing a description
* **Complete Task:** Mark a task as completed by entering its number
* **Exit:** Save tasks to `tasks.txt` and exit the application

All tasks are saved in the `tasks.txt` file located in the project directory.

---

## 👨‍💻 Development

### Building from Source

To build the application from source:

```bash
dotnet build
```

### Running Tests

To run the unit tests (if available):

```bash
dotnet test
```

### Publishing

To create a standalone executable:

```bash
dotnet publish -c Release -r win-x64 --self-contained
```


---

## 📁 Project Structure

```
TodoListApp/
├── .gitignore           # Ignores build artifacts (bin/, obj/)
├── Program.cs           # Main application code
├── TodoListApp.csproj   # Project configuration
├── tasks.txt            # File where tasks are stored
├── README.md            # Project documentation
└── LICENSE              # License file (MIT)
```

---

## ❓ Troubleshooting

### Common Issues

- **Application crashes on startup:**
  - Ensure you have the correct .NET SDK version installed
  - Check if `tasks.txt` has proper permissions

- **Tasks not saving:**
  - Verify write permissions in the application directory
  - Make sure to exit the application properly using the Exit option

- **Build errors:**
  - Run `dotnet restore` to restore dependencies
  - Update your .NET SDK if necessary

For additional help, [open an issue](https://github.com/NickiMash17/TodoListApp/issues/new) on the GitHub repository.

---

## 🤝 Contributing

Contributions are welcome! Here's how to contribute:

1. Fork the repository
2. Create a new branch

```bash
git checkout -b feature/your-feature
```

3. Make your changes and commit

```bash
git commit -m "Add your feature"
```

4. Push to your branch

```bash
git push origin feature/your-feature
```

5. Open a **Pull Request**

---

## 📜 License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

---

## 🙌 Acknowledgments

* Built as a portfolio project to demonstrate C# programming skills
* Inspired by simple task management applications
* Thanks to all [contributors](https://github.com/NickiMash17/TodoListApp/graphs/contributors)
