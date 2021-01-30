using System;

namespace Sort
{
    public class RadixSort
    {
        public int[] Sort(int[] array)
        {
            int m = GetMax(array, array.Length);

            // Do counting sort for every digit. Note that 
            // instead of passing digit number, exp is passed. 
            // exp is 10^i where i is current digit number 
            for (int exp = 1; m / exp > 0; exp *= 10)
                CountingSort(array, array.Length, exp);

            return array;
        }

        private void CountingSort(int[] array, int n, int exp)
        {
            int[] output = new int[n]; // output array 
            int i;
            int[] count = new int[10];

            // initializing all elements of count to 0 
            for (i = 0; i < 10; i++)
                count[i] = 0;

            // Store count of occurrences in count[] 
            for (i = 0; i < n; i++)
                count[(array[i] / exp) % 10]++;

            // Change count[i] so that count[i] now contains 
            // actual 
            //  position of this digit in output[] 
            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];

            // Build the output array 
            for (i = n - 1; i >= 0; i--)
            {
                output[count[(array[i] / exp) % 10] - 1] = array[i];
                count[(array[i] / exp) % 10]--;
            }

            // Copy the output array to arr[], so that arr[] now 
            // contains sorted numbers according to current 
            // digit 
            for (i = 0; i < n; i++)
                array[i] = output[i];
        }

        private T GetMax<T>(T[] array, int n) where T: IComparable
        {
            T mx = array[0];
            for (int i = 1; i < n; i++)
                if (array[i].CompareTo( mx) > 0)
                    mx = array[i];
            return mx;
        }
    }
}
