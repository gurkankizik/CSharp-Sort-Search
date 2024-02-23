using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Search
    {

        public static void MySearch(int[] array, int key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                {
                    Console.WriteLine("Key found at " + i);
                }
            }
        }

        public static void BinarySearch(int[] array, int key)
        {
            int l = 0;
            int r = array.Length - 1;

            while (l <= r)
            {
                int m = l + (r - 1) / 2;

                if (array[m] == key)
                    Console.WriteLine("Key found at " + m);

                if (array[m] < key)
                    l = m + 1;

                else
                    r = m - 1;
            }
        }
    }
}
