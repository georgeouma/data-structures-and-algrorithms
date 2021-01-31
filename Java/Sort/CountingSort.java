package Java.Sort;

public class CountingSort {
    public int[] sort(int[] array) {
        int size = array.length;

        int[] temp = new int[11];

        for (int i = 0; i < size; i++) { // populate the temp array
            temp[array[i]] = temp[array[i]] + 1;
        }

        int curr = 0;

        for (int i = 0; i < temp.length; i++) { // k iterations
            for (int j = 0; j < temp[i]; j++) { // n/k iterations for each (avg)
                array[curr] = i;
                curr++;
            }
        }

        return array;
    }
}