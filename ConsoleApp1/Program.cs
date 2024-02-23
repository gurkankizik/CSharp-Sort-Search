using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your array length: ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] MyArray = new int[0];
            MyArray = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine("Please enter number " + (i + 1) + ": ");
                MyArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Sort.MySort(MyArray);
            //Sort.QuickSort(MyArray, 0, MyArray.Length - 1);
            //Search.MySearch(MyArray, 12);
            //Search.BinarySearch(MyArray, 12);

            for (int j = 0; j < arrayLength; j++)
            {
                Console.Write(MyArray[j] + " ");
            }
        }
    }
}