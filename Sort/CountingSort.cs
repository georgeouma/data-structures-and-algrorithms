using System;

namespace Sort
{
    public class CountingSort
    {
        public int[] Sort(int[] array)
        {
			int[] temp = new int[11];

			for (int i = 0; i < array.Length; i++)
			{ // populate the temp array
				temp[array[i]] = temp[array[i]] + 1;
			}

			int curr = 0;

			for (int i = 0; i < temp.Length; i++)
			{ // k iterations
				for (int j = 0; j < temp[i]; j++)
				{ // n/k iterations for each (avg)
					array[curr] = i;
					curr++;
				}
			}

			return array;
		}
    }
}
