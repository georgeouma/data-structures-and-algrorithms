package Java.Sort;

import java.util.*;
import java.util.Collections;

public class BucketSort {
    public int[] sort(int[] array) {
        int[] sortedArray = new int[array.length];

        int numOfBuckets = 10;

        // Create buckets
        @SuppressWarnings("unchecked")
        Vector<Integer>[] buckets = new Vector[numOfBuckets];
        for (int i = 0; i < numOfBuckets; i++) {
            buckets[i] = new Vector<Integer>();
        }

        // Iterate through the passed array
        // and add each integer to the appropriate bucket
        for (int i = 0; i < array.length; i++) {
            int bucket = (array[i] / numOfBuckets);
            buckets[bucket].add(array[i]);
        }

        // Sort each bucket and add it to the result List
        int index = 0;
        for (int i = 0; i < numOfBuckets; i++) {
            Collections.sort(buckets[i]);
            for (int j = 0; j < buckets[i].size(); j++) {
                sortedArray[index++] = buckets[i].get(j);
            }
        }
        return sortedArray;
    }
}
