package Java.Sort;

/**
 * SelectionSort
 */
public class SelectionSort {
    public <T extends Comparable<T>> T[] sort(T[] array) {
        int arraySize = array.length;
        for (int i = 0; i < arraySize; i++) {
            int minValueIndex = i;
            for (int j = i; j < arraySize; j++) {
                if (array[j].compareTo(array[minValueIndex]) < 0) {
                    minValueIndex = j;
                }
            }

            if (array[i].compareTo(array[minValueIndex]) != 0) {
                T temp = array[i];
                array[i] = array[minValueIndex];
                array[minValueIndex] = temp;
            }
        }

        return array;
    }

}