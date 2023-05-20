using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна_робота__4
{
    public class MergeSort
    {
        private static void Merge(int[] arr, int start, int end)
        {
            for (int i = start; i < end + 1; i++)
            {
                for (int j = start; j < end + 1; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }
        private static void Sort(int[] arr, int start, int end)
        {
            int middle = (start + end) / 2;
            if (end > start)
            {
                Sort(arr, start, middle);
                Sort(arr, middle + 1, end);
                Merge(arr, start, end);
            }
        }
        public static void Sort(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
        }
    }
}
