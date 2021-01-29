using System;

namespace data_structures_and_algrorithms
{
    public interface ISort
    {
        T[] Sort<T>(T[] array) where T : IComparable;
    }

}
