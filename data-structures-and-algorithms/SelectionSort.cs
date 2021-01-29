using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algrorithms
{
    public class SelectionSort : ISort
    {
        public T[] Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minValueIndex = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[minValueIndex]) < 0)
                    {
                        minValueIndex = j;
                    }
                }

                if (array[i].CompareTo(array[minValueIndex]) != 0)
                {
                    T temp = array[i];
                    array[i] = array[minValueIndex];
                    array[minValueIndex] = temp;
                }
            }

            return array;
        }
    }
}
