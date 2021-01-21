using System;

public class Program
{
    static T[] BubbleSort<T>(T[] array) where T: IComparable
    {
        for (int i = array.Length-1; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (array[j].CompareTo(array[j+1]) > 0)
                {
                    T temp = array[j];
                    array[j] = array[j+1];
                    array[j+1] = temp;
                }
            }
        }

        return array;
    }
}

