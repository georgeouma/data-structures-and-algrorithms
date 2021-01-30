using System;

namespace Sort
{
    public class QuickSort : ISort
    {
        public T[] Sort<T>(T[] array) where T : IComparable
        {
            Sort(array, 0, array.Length - 1);

            return array;
        }

        private void Sort<T>(T[] array, int start, int end) where T : IComparable
        {
            if (start < end)
            {
                int pivotIndex = Partition(array, start, end);
                Sort(array, start, pivotIndex - 1);
                Sort(array, pivotIndex + 1, end);
            }           
        }

        private int Partition <T>(T[] array, int start, int end) where T : IComparable
        {
            T pivot = array[end];
            int i = start;
            for (int j = start; j <= end-1; j++)
            {
                if(array[j].CompareTo(pivot) < 0)
                {
                    T temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                }
            }

            array[end] = array[i];
            array[i] = pivot;

            return i;

        }
    }
}
