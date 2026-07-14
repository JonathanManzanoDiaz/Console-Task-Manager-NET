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
    }
}
