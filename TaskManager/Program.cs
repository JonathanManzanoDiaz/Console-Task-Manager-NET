namespace TaskManager {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");
            TaskManager manager = new();
            List<TaskItem> listaDeTareas = manager.GetTasks();
            GetTask(listaDeTareas);
        }
        public static void GetTask(List<TaskItem> tasks) {
                    foreach (var task in tasks) {
                if (task.IsCompleted == false) {
                    Console.WriteLine($"{task.ID} | [ ] {task.Title}");
                } else {
                    Console.WriteLine($"{task.ID} | [\u221A] {task.Title}");
                }
                }
            }
        }
    }
}