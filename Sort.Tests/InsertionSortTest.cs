﻿

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sort.Tests
{
    [TestClass]
    public class InsertionSortTest : ISortTest
    {
        [TestMethod]
        public void SortsInAscendingOrderTest()
        {
            int[] array = new int[] { 5, 4, 3, 2, 1, 7 };
            var sortedArray = new InsertionSort().Sort(array);

            Assert.AreEqual(sortedArray.Length, array.Length);
            for (int i = 0; i < array.Length - 1; i++)
            {
                Assert.IsTrue(sortedArray[i].CompareTo(sortedArray[i + 1]) <= 0);
            }
        }
    }
}
