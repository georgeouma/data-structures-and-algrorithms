using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algrorithms
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
            int middle = Convert.ToInt32(Math.Floor(Convert.ToDecimal((end - start) / 2)) + start);
            Console.WriteLine("sort: {0}, {1}, {2}", start, middle, end);
            if (middle > 0)
            {
                Sort(array, start, middle);
                //MergeSort(array, middle + 1, end);
            }

            Merge(array, start, middle, end);

            return array;
        }
        private void Merge<T>(T[] array, int start, int middle, int end) where T : IComparable
        {
            int mergedArrayLength = end - start + 1;
            T[] mergedArray = new T[mergedArrayLength];
            int pointer = 0;

            int leftPointer = start;
            int rightPointer = middle + 1;


            while (leftPointer <= middle || rightPointer <= end)
            {
                if (array[leftPointer].CompareTo(array[rightPointer]) <= 0)
                {
                    mergedArray[pointer] = array[leftPointer];
                    leftPointer++;
                }
                else
                {
                    mergedArray[pointer] = array[rightPointer];
                    rightPointer++;
                }
                pointer++;
            }

            pointer = 0;
            for (int i = start; i <= end; i++)
            {
                array[i] = mergedArray[pointer];
            }
        }
    }
}
