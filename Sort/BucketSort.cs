using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort
{
    public class BucketSort
    {
        public int[] Sort(int[] array)
        {
            List<int> sortedArray = new List<int>();

            int numOfBuckets = 10;

            //Create buckets
            List<int>[] buckets = new List<int>[numOfBuckets];
            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<int>();
            }

            //Iterate through the passed array 
            //and add each integer to the appropriate bucket
            for (int i = 0; i < array.Length; i++)
            {
                int bucket = (array[i] / numOfBuckets);
                buckets[bucket].Add(array[i]);
            }

            //Sort each bucket and add it to the result List
            for (int i = 0; i < numOfBuckets; i++)
            {
                List<int> temp = new InsertionSort().Sort(buckets[i].ToArray()).ToList<int>();
                sortedArray.AddRange(temp);
            }
            return sortedArray.ToArray();
        }
    }
}
