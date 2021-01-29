using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class InsertionSort : ISort
    {
        public T[] Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                T key = array[i];
                int pointer = i;
                while (pointer > 0 && key.CompareTo(array[pointer-1]) < 0)
                {
                    array[pointer] = array[pointer-1];
                    pointer--;
                }

                array[pointer] = key;
            }

            return array;
        }
    }
}
