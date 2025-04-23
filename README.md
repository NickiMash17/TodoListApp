# To-Do List Application

A simple, console-based To-Do List application built with C# and .NET. This project allows users to manage tasks by adding, viewing, completing, and saving them to a file. It demonstrates core C# concepts such as object-oriented programming, collections, file I/O, and user input handling.

## Features

- **Add Tasks**: Create new tasks with a description
- **View Tasks**: Display all tasks with their status (completed or pending)
- **Complete Tasks**: Mark tasks as completed
- **Persistent Storage**: Save tasks to a file (tasks.txt) and load them on startup
- **User-Friendly Interface**: Simple menu-driven console interface

## Technologies

- **Language**: C#
- **Framework**: .NET (compatible with .NET Core or .NET Framework)
- **IDE**: Visual Studio 2022 (or any C# compatible IDE)
- **File I/O**: Basic text file handling for task persistence

## Getting Started

### Prerequisites

- .NET SDK (version 6.0 or later recommended)
- Visual Studio (optional, for development)
- Git (for cloning the repository)

### Installation

1. **Clone the Repository**:
   ```
   git clone https://github.com/NickiMash17/TodoListApp.git
   cd TodoListApp
   ```

2. **Open the Project**:
   - Open `TodoListApp.sln` in Visual Studio, or
   - Navigate to the project folder in a terminal

3. **Run the Application**:
   - In Visual Studio: Press F5 or click Start
   - In terminal: Run `dotnet run`

## Usage

1. Launch the application
2. Choose from the menu options:
   - **View Tasks**: See all tasks
   - **Add Task**: Enter a task description to add it
   - **Complete Task**: Enter the task number to mark it as completed
   - **Exit**: Save tasks and exit

Tasks are automatically saved to `tasks.txt` in the project directory.

## Project Structure

```
TodoListApp/
├── .gitignore       # Ignores build artifacts (bin/, obj/)
├── Program.cs       # Main application code
├── TodoListApp.csproj  # Project configuration
├── README.md        # This file
└── LICENSE          # Project license (e.g., MIT)
```

## Contributing

Contributions are welcome! To contribute:

1. Fork the repository
2. Create a new branch (`git checkout -b feature/your-feature`)
3. Make your changes and commit (`git commit -m "Add your feature"`)
4. Push to your branch (`git push origin feature/your-feature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License.

## Acknowledgments

- Built as a demonstration of C# programming for portfolio purposes
- Inspired by simple task management applications
