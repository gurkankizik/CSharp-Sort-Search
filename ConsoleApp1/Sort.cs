using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sort
    {
        public static void MySort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        public static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);

                if (pivot > 1)

                    QuickSort(array, left, pivot - 1);
                if (pivot + 1 < right)
                    QuickSort(array, pivot + 1, right);
            }
        }
        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[left];

            while (true)
            {
                while (array[left] < pivot)
                    left++;

                while (array[right] > pivot)
                    right--;

                if (left < right)
                {
                    if (array[left] == array[right]) return right;

                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                }
                else
                    return right;
            }
        }
    }
}
