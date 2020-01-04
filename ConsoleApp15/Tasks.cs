using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Homework
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

            PrintArray(myArray);
            SwapArrayParts(myArray);
            PrintArray(myArray);
            TaskExit();
        }

        private static void SwapArrayParts(int[] myArray)
        {
            int firstPartEnd = myArray.Length / 2 ;
            int step = myArray.Length % 2 == 1 ? firstPartEnd + 1 : firstPartEnd;
            for (int i = 0; i < firstPartEnd; i++)
            {
                Swap(ref myArray[i], ref myArray[i + step]);
            }
        }

        private static void Swap(ref int num1, ref int num2)
        {
            int tmp = num1;
            num1 = num2;
            num2 = tmp;
        }

        public static void Task9(int[] myArray)
        {
            PrintArray(myArray);
            SortBubble(myArray);
            PrintArray(myArray);
            TaskExit();
        }

        private static void SortBubble(int[] myArray)
        {
            for (int i = 0; i < myArray.Length - 1 ; i++)
            {
                for (int j = 0; j < myArray.Length - 1 - i; j++)
                {
                    if (myArray[j] > myArray[j+1])
                    {
                        Swap(ref myArray[j], ref myArray[j + 1]);
                    }
                }
            }
        }

        public static void Task10(int[] myArray)
        {
            PrintArray(myArray);
            SortSelect(myArray);
            PrintArray(myArray);
            TaskExit();
        }

        private static void SortSelect(int[] myArray)
        {
            int[] tmp;
            for (int i = 0; i < myArray.Length; i++)
            {
                tmp = new int[myArray.Length - i];
                for (int j = 0; j < tmp.Length; j++)
                {
                    tmp[j] = myArray[j + i];
                }
                int minIndex = FindMinIndex(tmp);
                Swap(ref myArray[i], ref myArray[i + minIndex]);
            }
        }

        public static void Task11(int[] myArray)
        {
            PrintArray(myArray);
            SortInsert(myArray);
            PrintArray(myArray);
            TaskExit();
        }

        private static void SortInsert(int[] myArray)
        {
            int tmp;
            int j;
            for (int i = 0; i < myArray.Length; i++)
            {
                tmp = myArray[i];
                j = i - 1;
                while ((j >= 0) && (myArray[j ] > tmp))
                {
                    myArray[j + 1] = myArray[j];
                    j = j - 1;
                }
                myArray[j + 1] = tmp;
            }
        }

        public static void Task12(int[] myArray)
        {
            PrintArray(myArray);
            myArray = SortQuick(myArray);
            PrintArray(myArray);
            TaskExit();
        }

        private static int[] SortQuick(int[] myArray)
        {
            return SortQuick(myArray, 0, myArray.Length - 1);
        }

        private static int[] SortQuick(int[] myArray, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return myArray;
            }
            int pivotIndex = Partition(myArray, minIndex, maxIndex);
            SortQuick(myArray, minIndex, pivotIndex - 1);
            SortQuick(myArray, pivotIndex + 1, maxIndex);

            return myArray;
        }

        private static int Partition(int[] myArray, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (myArray[i] < myArray[maxIndex])
                {
                    pivot++;
                    Swap(ref myArray[pivot], ref myArray[i]);
                }
            }

            pivot++;
            Swap(ref myArray[pivot], ref myArray[maxIndex]);
            return pivot;
        }

        public static void Task13(int[] myArray)
        {
            PrintArray(myArray);
            myArray = MergeSort(myArray);
            PrintArray(myArray);
            TaskExit();
        }

        static void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new int[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (array[left] < array[right])
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                array[lowIndex + i] = tempArray[i];
            }
        }

        //сортировка слиянием
        static int[] MergeSort(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                MergeSort(array, lowIndex, middleIndex);
                MergeSort(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }

            return array;
        }

        static int[] MergeSort(int[] array)
        {
            return MergeSort(array, 0, array.Length - 1);
        }
        public static void Task14(int[] myArray)
        {
            PrintArray(myArray);
            myArray = ShellSort(myArray);
            PrintArray(myArray);
            TaskExit();
        }
        static int[] ShellSort(int[] array)
        {
            //расстояние между элементами, которые сравниваются
            var d = array.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < array.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (array[j - d] > array[j]))
                    {
                        Swap(ref array[j], ref array[j - d]);
                        j = j - d;
                    }
                }

                d = d / 2;
            }

            return array;
        }
        public static void Task15(int[] myArray)
        {
            PrintArray(myArray);
            HeapSort(myArray, myArray.Length);
            PrintArray(myArray);
            TaskExit();
        }

        public static void heapify(int[] arr, int pos, int n)
        {
            int temp;
            while (2 * pos + 1 < n)
            {
                int t = 2 * pos + 1; if (2 * pos + 2 < n && arr[2 * pos + 2] >= arr[t])
                {
                    t = 2 * pos + 2;
                }
                if (arr[pos] < arr[t]) { temp = arr[pos]; arr[pos] = arr[t]; arr[t] = temp; pos = t; } else break;
            }
        }
        public static void heap_make(int[] arr, int n)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                heapify(arr, i, n);
            }
        }
        public static void HeapSort(int[] arr, int n)
        {
            int temp;
            heap_make(arr, n);
            while (n > 0)
            {
                temp = arr[0];
                arr[0] = arr[n - 1];
                arr[n - 1] = temp;
                n--;
                heapify(arr, 0, n);
            }
        }

        public static void Task16(int[] myArray)
        {
            Random random = new Random();
            int day = random.Next(1, 355);
            string dayName = GetDayNameByNum(day);
            Console.WriteLine($"day chosen is dd/mm/yyyy 01/01/2020 + {day} =  {new DateTime(2020, 1, 1).AddDays(day)} ");
            Console.WriteLine(dayName);
            TaskExit();
        }

        private static string GetDayNameByNum(int days)
        {
            DateTime calculatedDate = new DateTime(2020, 1, 1);
            calculatedDate = calculatedDate.AddDays(days);

            string dayName = calculatedDate.DayOfWeek.ToString();
            Console.WriteLine(calculatedDate.DayOfWeek);

            return dayName;
        }

        public static void PrintArray(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"myArray[{i}] = {myArray[i]}");
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i]}  ");
            }
            Console.WriteLine();
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
