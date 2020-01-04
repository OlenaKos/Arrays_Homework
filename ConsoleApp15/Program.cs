using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Arrays_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Menu menu = new Menu(n);

            while (menu.IsRun)
            {
                menu.RunSelectedMenu(menu.SelectMenu(Menu.MenuArray()));   
            }
        }
    }
}
