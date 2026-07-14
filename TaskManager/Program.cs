namespace TaskManager {
    internal class Program {
        static void Main(string[] args) {
            Console.Title = "Task Manager By Jonathan Manzano Diaz";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Initializing TaskManager Engine...");
            Thread.Sleep(400);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Loading tasks.json database...");
            Thread.Sleep(400);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("System Ready! Launching Interface...");
            Thread.Sleep(500);
            Console.ResetColor();
            TaskManager manager = new();
            List<TaskItem> taskList = manager.GetTasks();
            
            string prompt = "Task Manager";
            string[] options = {"Show Tasks", "Add Task", "Remove Task", "Toggle Task", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            bool running = true;
            while (running) {
                int selectedOption = mainMenu.Run();
                Console.Clear(); 
                switch (selectedOption) {
                    case 0: // Show Tasks
                        Console.WriteLine("=== YOUR TASKS ===");
                        GetTask(manager.GetTasks());

                        Console.WriteLine("\nPress any key to return to the menu...");
                        Console.ReadKey(true);
                        break;

                    case 1: // Add Task
                        Console.WriteLine("=== ADD NEW TASK ===");
                        Console.Write("What is the name of the task?: ");
                        string title = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(title)) {
                            manager.AddTask(title);
                            Console.WriteLine("\nTask added successfully!");
                        } else {
                            Console.WriteLine("\nTask title cannot be empty!");
                        }

                        Console.WriteLine("Press any key to return to the menu...");
                        Console.ReadKey(true);
                        break;

                    case 2: // Remove Task
                        Console.WriteLine("=== REMOVE TASK ===");
                        GetTask(manager.GetTasks());
                        Console.Write("\nEnter the ID of the task to remove: ");

                        if (int.TryParse(Console.ReadLine(), out int removeId)) {
                            if (manager.RemoveTask(removeId)) {
                                Console.WriteLine("\nTask removed successfully!");
                            } else {
                                Console.WriteLine("\nTask ID not found.");
                            }
                        } else {
                            Console.WriteLine("\nInvalid ID format.");
                        }

                        Console.WriteLine("Press any key to return to the menu...");
                        Console.ReadKey(true);
                        break;

                    case 3: // Toggle Task
                        Console.WriteLine("=== TOGGLE TASK STATUS ===");
                        GetTask(manager.GetTasks());
                        Console.Write("\nEnter the ID of the task to toggle: ");

                        if (int.TryParse(Console.ReadLine(), out int toggleId)) {
                            if (manager.ToggleTask(toggleId)) {
                                Console.WriteLine("\nTask status updated!");
                            } else {
                                Console.WriteLine("\nTask ID not found.");
                            }
                        } else {
                            Console.WriteLine("\nInvalid ID format.");
                        }

                        Console.WriteLine("Press any key to return to the menu...");
                        Console.ReadKey(true);
                        break;

                    case 4: // Exit
                        running = false;
                        Console.WriteLine("Goodbye! Thanks for using Task Manager.");
                        break;

                    default:
                        break;
                }
            }
        }

        public static void GetTask(List<TaskItem> tasks) {
            if (tasks.Count == 0) {
                Console.WriteLine("No tasks found. Add some tasks first!");
                return;
            }

            foreach (var task in tasks) {
                if (task.IsCompleted == false) {
                    Console.WriteLine($"{task.ID} | [ ] {task.Title}"); //
                } else {
                    Console.WriteLine($"{task.ID} | [\u221A] {task.Title}"); //
                }
            }
        }
    }
}