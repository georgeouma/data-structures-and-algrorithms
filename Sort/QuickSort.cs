using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class QuickSort : ISort
    {
        public T[] Sort<T>(T[] array) where T : IComparable
        {
            throw new NotImplementedException();
        }

        private T[] Sort<T>(T[] array, int start, int end) where T : IComparable
        {
            if(start < end)
            {

            }
            return array;
        }

        private int Partition <T>(T[] array, int start, int end) where T : IComparable
        {
            throw new NotImplementedException();

        }
    }
}
