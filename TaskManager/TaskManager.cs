using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace TaskManager {
    class TaskManager {
        private List<TaskItem> _tasks = new List<TaskItem>();
        private readonly string _filePath;
        public TaskManager(string filePath = "tasks.json") {
            _filePath = filePath;
            LoadTasks();
        }
        public void AddTask(string title) {
            TaskItem newTask = new(title);
            _tasks.Add(newTask);
            SaveTasks();
        }
        public List<TaskItem> GetTasks() {
            return _tasks;
        }
        public bool RemoveTask(int id) {
            TaskItem taskToDelete = null;
            foreach(var task in _tasks) {
                // Search for task and select the one you want to delete.
                if (task.ID == id) {
                    taskToDelete = task;
                    break;
                }
            }
            if (taskToDelete != null) {
                _tasks.Remove(taskToDelete);
                SaveTasks();
                return true;

            }
            return false;
        }
        public bool ToggleTask(int id) {
            TaskItem taskToToggle = null;
            foreach(var task in _tasks) {
                if(task.ID == id) {
                    taskToToggle = task;
                    break;
                }
            }
            if (taskToToggle != null) {
                taskToToggle.IsCompleted = !taskToToggle.IsCompleted;
                SaveTasks();
                return true;
            }
            return false;
        }
        private void SaveTasks() {
            string jsonString = JsonSerializer.Serialize(_tasks, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(_filePath, jsonString);
        }
        private void LoadTasks() {
            if (!File.Exists(_filePath)) {
                return;
            }

            string jsonString = File.ReadAllText(_filePath);
            _tasks = JsonSerializer.Deserialize<List<TaskItem>>(jsonString) ?? new List<TaskItem>();

            if (_tasks.Count > 0) {
                int maxId = 0;
                foreach (var task in _tasks) {
                    if (task.ID > maxId) {
                        maxId = task.ID;
                    }
                }
                TaskItem.UpdateNextId(maxId);
            }
        }
    }

}
