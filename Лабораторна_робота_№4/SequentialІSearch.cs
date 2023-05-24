using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна_робота__4
{
    public class SequentialІSearch
    {
        public static int Search(int[] arr, int number,List<int>indexes)
        {
            int index = 0;
            foreach(int item in arr) 
            {
                if (item == number)
                    index++;
            }
            return index;
        }
    }
}
