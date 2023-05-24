using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна_робота__4
{
    public class BinarySearch
    {
        private static int CountNumbInArr(int[] arr, int position,int number)
        {
            int index = 1;
            if(position == 0)
            {
                while (arr[++ position] == number)
                    index++;
            }
            else if (arr[position + 1] == number)
            {
                while (arr[++position]==number)
                    index++;
            }
            else if(position==arr.Length-1 || arr[position - 1] == number)
            {
                while (arr[--position] == number)
                    index++;
            }
            return index;
        }
        public static int Search(int[]arr,int number)
        {
            int middle = arr.Length / 2;
            int start = 0;
            int end =arr.Length-1;
            int position = 0;
            if (arr[start] == number)
            {
                return CountNumbInArr(arr, start,number);
            }
            else if (arr[end] == number) 
            {
                return CountNumbInArr(arr, end, number);
            }
            while(start!=middle)
            {
                if (number > arr[middle])
                {
                    start = middle;
                    middle = (start + end) / 2;
                }
                else if(number < arr[middle])
                {
                    end = middle;
                    middle = (start + end) / 2;
                }
                if (number == arr[middle])
                {
                    position = middle;
                    return CountNumbInArr(arr, position, number);
                }
            }
            return position;
        }
    }
}
