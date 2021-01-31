package Java.Sort;

public class InsertionSorter {

	public <T extends Comparable<T>> T[] sort(T[] array) {
		for (int i = 0; i < array.length; i++) {
			T key = array[i];
			int pointer = i;
			while (pointer > 0 && key.compareTo(array[pointer - 1]) < 0) {
				array[pointer] = array[pointer - 1];
				pointer--;
			}

			array[pointer] = key;
		}

		return array;
	}

}
