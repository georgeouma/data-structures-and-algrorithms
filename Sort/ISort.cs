using System;

namespace Sort
{
    public interface ISort
    {
        T[] Sort<T>(T[] array) where T : IComparable;
    }

}
