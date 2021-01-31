package Java.Sort;

public class ShellSort {
    public <T extends Comparable<T>> T[] sort(T[] array) {
        if (array == null || array.length == 0)
            return array;

        int knuthNum = maxKnuthSeqNumber(array.length);
        while (knuthNum >= 1) {
            for (int i = 0; i < knuthNum; i++) {
                // internally we use insertion sort for each pass
                insertionSortWithGap(array, i, knuthNum);
            }
            knuthNum = (knuthNum - 1) / 3; // decrease the gap
        }

        return array;
    }

    private <T extends Comparable<T>> void insertionSortWithGap(T[] array, int startIndex, int gap) {
        int i = startIndex;
        while (i < array.length) {
            T current = array[i];
            int j = i - gap;
            while (j >= 0 && array[j].compareTo(current) >= 0) {
                array[j + gap] = array[j];
                j -= gap;
            }
            array[j + gap] = current;
            i += gap;
        }
    }

    private int maxKnuthSeqNumber(int size) {
        int h = 1;

        while (h < size / 3) {
            h = 3 * h + 1;
        }

        return h;
    }
}