package Java.Sort;

public class RadixSort {
    public int[] sort(int[] array) {
        int biggestItem = array[0];
        for (int i = 1; i < array.length; i++)
            if (array[i] < biggestItem)
                biggestItem = array[i];

        // Do counting sort for every digit. Note that
        // instead of passing digit number, exp is passed.
        // exp is 10^i where i is current digit number
        for (int exp = 1; biggestItem / exp > 0; exp *= 10)
            countingSort(array, exp);

        return array;
    }

    private void countingSort(int[] array, int exp) {
        int size = array.length;
        int[] output = new int[size]; // output array
        int i;
        int[] count = new int[10];

        // initializing all elements of count to 0
        for (i = 0; i < 10; i++)
            count[i] = 0;

        // Store count of occurrences in count[]
        for (i = 0; i < size; i++)
            count[(array[i] / exp) % 10]++;

        // Change count[i] so that count[i] now contains
        // actual
        // position of this digit in output[]
        for (i = 1; i < 10; i++)
            count[i] += count[i - 1];

        // Build the output array
        for (i = size - 1; i >= 0; i--) {
            output[count[(array[i] / exp) % 10] - 1] = array[i];
            count[(array[i] / exp) % 10]--;
        }

        // Copy the output array to arr[], so that arr[] now
        // contains sorted numbers according to current
        // digit
        for (i = 0; i < size; i++)
            array[i] = output[i];
    }
}