# Console Task Manager (.NET)

A clean, interactive, and user-friendly Command Line Interface (CLI) application built with **C# and .NET** to manage your daily tasks. Instead of typing numbers or commands, this application features a **fancy keyboard-controlled menu** that allows you to navigate through options effortlessly using your arrow keys.

This project is part of my progress through the **.NET Backend Developer Roadmap** to master the fundamentals of C# and OOP before diving into backend frameworks.

---

## 🌟 Key Features

*   **Keyboard-Controlled Navigation:** Seamlessly move up and down through the menus using the `Up Arrow` and `Down Arrow` keys, and select options with `Enter`.
*   **Active Selection Highlighting:** Visual contrast reversal (highlighted text and asterisk pointer) to clearly show which item is selected.
*   **Task Management (CRUD):** 
    *   **Create:** Add new tasks with real-time input validation (no empty/whitespace-only titles allowed).
    *   **Read:** View your task list categorized with visual icons (`[ ]` for pending, `[✔]` for completed).
    *   **Update:** Toggle task completion status easily.
    *   **Delete:** Remove tasks safely.
*   **Robust Error Handling:** Zero crashes. The application gracefully handles empty states (e.g., trying to complete a task when the list is empty) and potential exceptions.
*   **OOP Best Practices:** Codebase separated cleanly into logical classes (`Program`, `TaskItem`, `TaskManager`, and `Menu`) to respect the Single Responsibility Principle.

---

## 🛠️ Tech Stack & Concepts Applied

*   **Language:** C# 10+ / .NET 6+ / .NET 8
*   **Application Type:** Console / CLI (Command Line Interface)
*   **C# Concepts:** Classes, Object-Oriented Programming (OOP), Collections (`List<T>`), Console Key Interception (`Console.ReadKey`), Conditional Control Flow, and String Formatting.

---

## 📂 Project Structure

```text
├── Program.cs         # Application entry point and main flow control
├── TaskItem.cs        # Model representing a single task (Id, Title, IsCompleted)
├── TaskManager.cs     # Business logic layer for managing tasks (Add, Remove, Toggle, List)
├── Menu.cs            # Reusable keyboard-driven menu system
└── README.md          # Documentation
```

---

## 🚀 Getting Started

### Prerequisites
Make sure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.

### Installation
1. Clone this repository:
   ```bash
   git clone https://github.com/YOUR_USERNAME/ConsoleTaskManager.git
   ```
2. Navigate to the project folder:
   ```bash
   cd ConsoleTaskManager
   ```

### Running the App
Run the application using the .NET CLI:
```bash
dotnet run
```

---

## 🎮 How to Use

1. Run the app to open the **Main Menu**.
2. Use the **Up/Down Arrow keys** to highlight your desired action.
3. Press **Enter** to confirm your choice.
4. Follow the clear on-screen prompts to write task titles or modify your list.
5. Select **Exit** to close the program safely.

---

## 📸 Preview / Demo

```text
======================================
     CONSOLE TASK MANAGER v1.0
======================================

Use your Arrow Keys to navigate, press Enter to select:

 * [View Pending Tasks]   <-- (Selected)
   [Add New Task]
   [Mark Task as Completed]
   [Delete a Task]
   [Exit]
```
"# Console-Task-Manager-NET" 
