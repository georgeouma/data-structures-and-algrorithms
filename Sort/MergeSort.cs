using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class MergeSort : ISort
    {
        public T[] Sort<T>(T[] array) where T : IComparable
        {
            int start = 0;
            int end = array.Length - 1;

            T[] result = Sort(array, start, end);

            return result;
        }

        private T[] Sort<T>(T[] array, int start, int end) where T : IComparable
        {
            if(start < end)
            {
                int middle = Convert.ToInt32(Math.Floor(Convert.ToDecimal((end - start) / 2)) + start);

                Sort(array, start, middle);
                Sort(array, middle + 1, end);
                Merge(array, start, middle, end);
            }
            

            return array;
        }
        private void Merge<T>(T[] array, int start, int middle, int end) where T : IComparable
        {
            int leftSize = (middle - start) + 1;
            int rightSize = (end - middle);

            T[] left = new T[leftSize];
            T[] right = new T[rightSize];

            for (int i = 0; i < leftSize; i++)
            {
                left[i] = array[start + i];
            }
            for (int i = 0; i < rightSize; i++)
            {
                right[i] = array[middle + 1 + i];
            }

            int leftPointer = 0;
            int rightPointer = 0;

            for (int i = start; i <= end; i++)
            {
                if(leftPointer >= leftSize)
                {
                    array[i] = right[rightPointer];
                    rightPointer++;
                }else if(rightPointer >= rightSize)
                {
                    array[i] = left[leftPointer];
                    leftPointer++;
                }else if(left[leftPointer].CompareTo(right[rightPointer]) <= 0)
                {
                    array[i] = left[leftPointer];
                    leftPointer++;
                }
                else
                {
                    array[i] = right[rightPointer];
                    rightPointer++;
                }
            }
        }
    }
}
