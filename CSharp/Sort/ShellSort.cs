using System;

namespace Sort
{
    public class ShellSort : ISort
    {
        public T[] Sort<T>(T[] array) where T : IComparable
        {
            if (array == null || array.Length == 0)
                return array;

            int knuthNum = MaxKnuthSeqNumber(array.Length);
            while (knuthNum >= 1)
            {
                for (int i = 0; i < knuthNum; i++)
                {
                    // internally we use insertion sort for each pass
                    InsertionSortWithGap(array, i, knuthNum);
                }
                knuthNum = (knuthNum - 1) / 3; //decrease the gap
            }

            return array;
        }

        private void InsertionSortWithGap<T>(T[] array, int startIndex, int gap) where T:IComparable
        {
            int i = startIndex;
            while (i < array.Length)
            {
                T current = array[i];
                int j = i - gap;
                while (j >= 0 && array[j].CompareTo(current) >= 0)
                {
                    array[j + gap] = array[j];
                    j -= gap;
                }
                array[j + gap] = current;
                i += gap;
            }
        }

        private int MaxKnuthSeqNumber(int size)
        {
            int h = 1;

            while (h < size / 3)
            {
                h = 3 * h + 1;
            }

            return h;
        }
    }
}
