using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна_робота__4
{
    public class BinarySearch
    {
        public static List<int> Search(int[]arr,int number)
        {
            int middle = arr.Length / 2;
            int start = 0;
            int end =arr.Length-1;
            List<int> list = new List<int>();
            while(true)
            {
                if (arr[middle] == number)
                {
                    list.Add(middle);
                    if (arr[middle + 1] == number)
                    {
                        for (int i = middle+1; i < end; i++)
                        {
                            if (arr[i] == number)
                                list.Add(arr[i]);
                            else
                                break;
                        }
                    }
                    if (arr[middle - 1] == number)
                    {
                        for (int i = middle-1; i >= start; i--)
                        {
                            if (arr[i] == number)
                                list.Add(arr[i]);
                            else
                                break;
                        }
                    }
                    break;
                }
                if (arr[end] == number) 
                {
                    list.Add(end);
                    for (int i = end-1; i >= start; i--)
                    {
                        if (arr[i] == number)
                            list.Add(arr[i]);
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
            return list;
        }
    }
}
