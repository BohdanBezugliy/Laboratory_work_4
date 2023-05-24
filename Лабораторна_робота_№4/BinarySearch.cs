using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна_робота__4
{
    public class BinarySearch
    {
        private static int CountNumbInArr(int[] arr, int position,int number,List<int>indexes)
        {
            int index = 1;
            indexes.Add(position);
            if (position == 0)
            {
                while (arr[++ position] == number)
                {
                    index++;
                    indexes.Add(position);
                }
            }
            else if(position==arr.Length-1 || arr[position - 1] == number)
            {
                while (arr[--position] == number)
                {
                    index++;
                    indexes.Add(position);
                }
            }
            else if (arr[position + 1] == number)
            {
                while (arr[++position] == number)
                {
                    index++;
                    indexes.Add(position);
                }
            }
            return index;
        }
        public static int Search(int[]arr,int number,List<int>indexes)
        {
            int middle = arr.Length / 2;
            int start = 0;
            int end =arr.Length-1;
            int position = 0;
            if (arr[start] == number)
            {
                return CountNumbInArr(arr, start,number,indexes);
            }
            else if (arr[end] == number) 
            {
                return CountNumbInArr(arr, end, number, indexes);
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
                    return CountNumbInArr(arr, position, number,indexes);
                }
            }
            return position;
        }
    }
}
