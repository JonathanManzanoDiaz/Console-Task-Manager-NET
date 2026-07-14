using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager {
    class TaskItem {
        public int ID { get; set; }
        private static int _nextId = 1;
        public string Title { get; set; } = string.Empty;
        public bool IsCompleted { get; set; } = false;
        public TaskItem(string title) {
            ID = _nextId++;
            Title = title;
        }
        public static void UpdateNextId(int currentMaxId) {
            _nextId = currentMaxId + 1;
        }
    }
}
