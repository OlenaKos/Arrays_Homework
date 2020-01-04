using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] myArray = Tasks.CreateArray(n);

            bool flag = true;
            //Tasks work = new Tasks();
            Menu menu = new Menu();
            Type TaskType = typeof(Tasks);

            while (flag)
            {
                int MenuNum = menu.SelectMenu(menu.MenuArray()) + 1;
                string MethodName = "Task" + MenuNum;
                MethodInfo method = TaskType.GetMethod(MethodName);

                object task = method.Invoke( null, new object[] { myArray });
                
            }
            
















        }


    }
}
