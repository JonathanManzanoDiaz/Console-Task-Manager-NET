using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager {
    class Menu {
        public string Prompt;
        public string[] Options;
        public int SelectedIndex;
        public Menu(string prompt, string[] options) {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
        }
        private void DisplayOptions() {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Task Manager By Jonathan Manzano Diaz");

            Console.WriteLine(@"
 ██████╗  ██████╗ ███╗   ██╗███████╗ ██████╗ ██╗     ███████╗
██╔════╝ ██╔═══██╗████╗  ██║██╔════╝██╔═══██╗██║     ██╔════╝
██║      ██║   ██║██╔██╗ ██║███████╗██║   ██║██║     █████╗  
██║      ██║   ██║██║╚██╗██║╚════██║██║   ██║██║     ██╔══╝  
╚██████╗ ╚██████╔╝██║ ╚████║███████║╚██████╔╝███████╗███████╗
 ╚═════╝  ╚═════╝ ╚═╝  ╚═══╝╚══════╝ ╚═════╝ ╚══════╝╚══════╝
    ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" ──────────────────────────────────────────────────────────");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n >> {Prompt} << \n");
            Console.ResetColor();

            string prefix = " *";
            for (int i = 0; i < Options.Length; i++) {
                if (i == SelectedIndex) {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($"{prefix}  {Options[i]} ");
                } else {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"    {Options[i]} ");
                }
            }
            Console.ResetColor();
            Console.WriteLine(); 
        }
        public int Run() {
            ConsoleKey keyPressed;
            Console.CursorVisible = false;
            do {
                Console.Clear();
                DisplayOptions();
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;
                if (keyPressed == ConsoleKey.UpArrow) {
                    SelectedIndex--;
                    if (SelectedIndex == -1) {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                if (keyPressed == ConsoleKey.DownArrow) {
                    SelectedIndex++;

                    if (SelectedIndex == Options.Length) {
                        SelectedIndex = 0;
                    }
                }
            } while (keyPressed != ConsoleKey.Enter);
            return SelectedIndex;
        }
    }
}
