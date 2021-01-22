using System;

public class Program
{
    static int Main(string[] args)
    {

        return 0;
    }
    static T[] BubbleSort<T>(T[] array) where T : IComparable
    {
        for (int i = array.Length - 1; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    T temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }

        return array;
    }

    static T[] SelectionSort<T>(T[] array) where T : IComparable
    {
        for (int i = 0; i < array.Length; i++)
        {
            int minValueIndex = i;
            for (int j = i; j < array.Length; j++)
            {
                if (array[j].CompareTo(array[minValueIndex]) < 0)
                {
                    minValueIndex = j;
                }
            }

            if (array[i].CompareTo(array[minValueIndex]) != 0)
            {
                T temp = array[i];
                array[i] = array[minValueIndex];
                array[minValueIndex] = temp;
            }
        }

        return array;
    }
    static T[] InsertionSort<T>(T[] array) where T : IComparable
    {
        for (int i = 1; i < array.Length; i++)
        {
            T current = array[i];
            for (int j = i; j > 0; j--)
            {
                if (current.CompareTo(array[j - 1]) < 0)
                {
                    array[j] = array[j - 1];
                    if (j == 1)
                    {
                        array[j - 1] = current;
                        break;
                    }
                }
                continue;
                if (current.CompareTo(array[j - 1]) > 0)
                {
                    array[j] = current;
                    break;
                }
            }
        }

        return array;
    }

}

