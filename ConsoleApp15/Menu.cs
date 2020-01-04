using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Arrays_Homework
{
    class Menu
    {
        public int Index { get; set; } = 0;
        public bool IsRun { get; set; } = true;
        public int[] myArray { get; set; }  = Tasks.CreateArray(10);

        public Menu(int n)
        {
            myArray = Tasks.CreateArray(n);
        }

        public Menu()
        {
        }

        public static string[] MenuArray()
        {
            string[] str = {
                "1. Find min element" ,
                "2. Find max element",
                "3. Find min index",
                "4. Find max index",
                "5. Get summma of odd elements of array",
                "6. Make a array reverse" ,
                "7. Get amount of odd array elements",
                "8. Swap left and right parts of array, e.g. 1234 have to became 3412",
                "9. Sort array(bubble)",
                "10. Sort array(Select)",
                "11. Sort array(Insert)",
                "12. Sort array(Quick)",
                "13. Sort array(Merge)",
                "14. Sort array(Shell)",
                "15. Sort array(Heap)",
                "16. Get name of day of week by day's number",
                "17. Exit"
            };

            return str;
        }

        private static string GetMethodName(int menuNum)
        {
            string methodName;
            if (menuNum == Menu.MenuArray().Length)
            {
                methodName = "Exit";
            }
            else
            {
                methodName = "Task" + menuNum;
            }
            return methodName;
        }
        public void RunSelectedMenu(int MenuNum)
        {
            Type TaskType = typeof(Tasks);
            string MethodName = GetMethodName(MenuNum);
            if (MethodName == "Exit")
            {
                IsRun = false;
            }
            else
            {
                MethodInfo method = TaskType.GetMethod(MethodName);
                object task = method.Invoke(null, new object[] { myArray });
            }
        }

        public int SelectMenu(string[] MenuItem)
        {
            bool flag = true;

            while (flag)
            {

                PrintMenu(Index);
                ConsoleKeyInfo ckey = Console.ReadKey(); // waiting for the managing keys 

                if (ckey.Key == ConsoleKey.DownArrow)
                {
                    if (Index == MenuItem.Length - 1)
                    {
                        Index = 0;
                    }
                    else
                        Index++;
                }

                else if (ckey.Key == ConsoleKey.UpArrow)
                {
                    if (Index <= 0)
                    {
                        Index = MenuItem.Length - 1;
                    }
                    else
                        Index--;
                }

                else if (Char.IsDigit(ckey.KeyChar))
                {
                    Index = Int32.Parse($"{ckey.KeyChar}") - 1;
                }

                else if (ckey.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    WriteFullLine($"****{MenuItem[Index]}*****", ConsoleColor.Yellow, ConsoleColor.Magenta);
                    Console.ResetColor();
                    break;
                }
                Console.SetCursorPosition(0, 0);

            }
            Index++;
            return Index;
        }

        public static void PrintMenu(int Index)
        {
            string[] MenuItem = MenuArray();

            for (int i = 0; i < MenuItem.Length; i++)
            {
                if (i == Index)
                {
                    WriteFullLine($"****{MenuItem[i]}*****", ConsoleColor.Yellow, ConsoleColor.Magenta);
                }
                else
                {
                    WriteFullLine($"{MenuItem[i]}", ConsoleColor.White, ConsoleColor.Blue);
                }
                Console.ResetColor();
            }

        }
        public static void WriteFullLine(string str, ConsoleColor backgroundColor = ConsoleColor.Green, ConsoleColor foregroundColor = ConsoleColor.DarkGreen)
        {
            //
            // This method writes an entire line to the console with the string.
            //
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
            Console.WriteLine(str.PadRight(Console.WindowWidth - 1)); 
            Console.ResetColor();
        }
    }
}
