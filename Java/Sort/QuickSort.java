package Java.Sort;

public class QuickSort {
    public <T extends Comparable<T>> T[] sort(T[] array) {
        Sort(array, 0, array.length - 1);

        return array;
    }

    private <T extends Comparable<T>> void Sort(T[] array, int start, int end) {
        if (start < end) {
            int pivotIndex = Partition(array, start, end);
            Sort(array, start, pivotIndex - 1);
            Sort(array, pivotIndex + 1, end);
        }
    }

    private <T extends Comparable<T>> int Partition(T[] array, int start, int end) {
        T pivot = array[end];
        int i = start;
        for (int j = start; j <= end - 1; j++) {
            if (array[j].compareTo(pivot) < 0) {
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