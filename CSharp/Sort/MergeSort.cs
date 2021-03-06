﻿using System;

namespace Sort
{
    public class MergeSort : ISort
    {
        public T[] Sort<T>(T[] array) where T : IComparable
        {
            int start = 0;
            int end = array.Length - 1;

            Sort(array, start, end);

            return array;
        }

        private void Sort<T>(T[] array, int start, int end) where T : IComparable
        {
            if(start < end)
            {
                int middle = Convert.ToInt32(Math.Floor(Convert.ToDecimal((end - start) / 2)) + start);

                Sort(array, start, middle);
                Sort(array, middle + 1, end);
                Merge(array, start, middle, end);
            }
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
            for (int k = start; k <= end; k++)
            {
                if((rightPointer >= rightSize) || (leftPointer < leftSize && left[leftPointer].CompareTo(right[rightPointer]) <= 0))
                {
                    array[k] = left[leftPointer];
                    leftPointer++;
                }
                else
                {
                    array[k] = right[rightPointer];
                    rightPointer++;
                }
            }
        }
    }
}
