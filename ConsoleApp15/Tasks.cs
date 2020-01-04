using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    static class Tasks
    {
        public static void Task1(int [] myArray)
        {
            PrintArray(myArray);
            int min = FindMinElement(myArray);
            Console.WriteLine(min);
            TaskExit();

        }

        public static void TaskExit()
        {
            Console.ReadLine();
            Console.Clear();
        }

        public static void Task2(int [] myArray)
        {
            PrintArray(myArray);
            int max = FindMaxElement(myArray);
            Console.WriteLine(max);
            TaskExit();
        }

        public static void Task3(int[] myArray)
        {
            PrintArray(myArray);
            int minIndex = FindMinIndex(myArray);
            Console.WriteLine(minIndex);
            TaskExit();
        }

        public static void Task4(int[] myArray)
        {
            PrintArray(myArray);
            int maxIndex = FindMaxIndex(myArray);
            Console.WriteLine(maxIndex);
            TaskExit();
        }

        public static void Task5(int[] myArray)
        {
            PrintArray(myArray);
            int SumOddElements = FindSummOddElements(myArray);
            Console.WriteLine(SumOddElements);
            TaskExit();
        }

        public static void Task6(int[] myArray)
        {
            PrintArray(myArray);
            ReverseArray(myArray);
            PrintArray(myArray);
            TaskExit();
        }

        private static void ReverseArray(int[] myArray)
        {
            int[] temp = new int[myArray.Length];
            int j = 0;
            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                temp[j] = myArray[i];
                j++;
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = temp[i];
            }

        }

        public static void Task7(int[] myArray)
        {
            PrintArray(myArray);
            int amount = GetOddAmount(myArray);
            Console.WriteLine(amount);
            TaskExit();
        }

        private static int GetOddAmount(int[] myArray)
        {
            int amount = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (Math.Abs(myArray[i] %2) == 1)
                {
                    amount++;
                }
            }

            return amount;
        }

        public static void Task8(int[] myArray)
        {

            TaskExit();
        }

        public static void Task9(int[] myArray)
        {
            TaskExit();
        }

        public static void Task17(int[] myArray)
        {
            int step = 2;
            int startPosition = 4;

            MakeShift(myArray, startPosition, step);
        }

        private static void MakeShift(int[] myArray, int startPosition, int step)
        {
            int endPosition = (startPosition - 1) < 0 ? 0 : startPosition - 1;
            int temp;
            //int counter = 0;
            int currentPosition = startPosition;

            while (currentPosition < myArray.Length)
            {
                currentPosition++;
            }
        }
        private static void MakeShift(int[] myArray, int startPosition)
        {
            startPosition = 1;
            int endPosition = (startPosition - 1) < 0 ? 0 : startPosition - 1;
            int temp;
            //int counter = 0;
            int currentPosition = startPosition;

            while (currentPosition < myArray.Length)
            {
                currentPosition++;
            }
        }

        public static void PrintArray(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"myArray[{i}] = {myArray[i]}");
            }
        }

        public static int FindSummOddElements(int[] myArray)
        {
            int sum = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sum += myArray[i];
                }
            }
            return sum;
        }

        public static int FindMaxIndex(int[] myArray)
        {
            int maxID = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > myArray[maxID])
                {
                    maxID = i;
                }
            }
            return maxID;
        }

        public static int FindMinIndex(int[] myArray)
        {
            int minID = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < myArray[minID])
                {
                    minID = i;
                }
            }
            return minID;
        }

        public static int FindMaxElement(int[] myArray)
        {
            int max = myArray[0];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > max)
                {
                    max = myArray[i];
                }
            }
            return max;
        }

        public static int[] CreateArray(int n)
        {
            int[] myArray = new int[n];
            Random random = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(-100, 101);
            }
            return myArray;
        }

        public static int FindMinElement(int[] myArray)
        {
            int min = myArray[0];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < min)
                {
                    min = myArray[i];
                }
            }
            return min;
        }
    }
}
