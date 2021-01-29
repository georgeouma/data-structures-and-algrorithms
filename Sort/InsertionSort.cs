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
                T current = array[i];
                for (int j = i; j > 0; j--)
                {
                    if (current.CompareTo(array[j - 1]) < 0)
                    {
                        array[j] = array[j - 1];
                        if (j == 1)
                        {
                            array[j - 1] = current;
                            break;
                        }
                        continue;
                    }
                    if (current.CompareTo(array[j - 1]) > 0)
                    {
                        array[j] = current;
                        break;
                    }
                }
            }

            return array;
        }
    }
}
