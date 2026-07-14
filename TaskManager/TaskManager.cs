using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager {
    class TaskManager {
        private List<TaskItem> _tasks = new List<TaskItem>();
        private readonly string _filePath;
        public TaskManager(string filePath = "tasks.json") {
            _filePath = filePath;
        }
        public void AddTask(string title) {
            TaskItem newTask = new(title);
            _tasks.Add(newTask);
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
                return true;
            }
            return false;
        }
    }

}
