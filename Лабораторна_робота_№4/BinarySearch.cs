using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна_робота__4
{
    public class BinarySearch
    {
        public static int Search(int[]arr,int number)
        {
            int middle = arr.Length / 2;
            int start = 0;
            int end =arr.Length-1;
            int index = 0;
            while(true)
            {
                if (arr[middle] == number)
                {
                    index++;
                    if (arr[middle + 1] == number)
                    {
                        for (int i = middle+1; i < end; i++)
                        {
                            if (arr[i] == number)
                                index++;
                            else
                                break;
                        }
                    }
                    if (arr[middle - 1] == number)
                    {
                        for (int i = middle-1; i >= start; i--)
                        {
                            if (arr[i] == number)
                                index++;
                            else
                                break;
                        }
                    }
                    break;
                }
                if (arr[end] == number) 
                {
                    index++;
                    for (int i = end-1; i >= start; i--)
                    {
                        if (arr[i] == number)
                            index++;
                        else
                            break;
                    }
                    break;
                }
                if (arr[start] == number)
                {
                    index++;
                    for (int i = start + 1; i < end; i++)
                    {
                        if (arr[i] == number)
                            index++;
                        else
                            break;
                    }
                    break;
                }
                if (middle==0||middle==start)
                {
                    break;
                }
                if (arr[middle]<number) 
                {
                    start = middle;
                    middle = (middle + end)/2;
                }
                else 
                {
                    end = middle;
                    middle =(middle + start)/2;
                }
            }
            return index;
        }
    }
}
