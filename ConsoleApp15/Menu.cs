using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Menu
    {
        public int Index { get; set; } = 0;

        public string[] MenuArray()
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
                "16. Get name of day of week by day's name",
                "17. Make a shift by two elements starting from n- element",
                "18. Exit"
            };

            return str;
        }
        public int SelectMenu(string[] MenuItem)
        {
            bool flag = true;

            while (flag)
            {
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
                    //Console.WriteLine(MenuArray()[Index]);
                    Console.ResetColor();
                    return Index;
                }

                Console.Clear();

            }
            return Index;
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
