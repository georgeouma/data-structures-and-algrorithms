using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sort.Tests
{
    [TestClass()]
    public class RadixSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            int[] array = new int[] { 5, 4, 3, 2, 1 };
            var sortedArray = new RadixSort().Sort(array);

            Assert.AreEqual(sortedArray.Length, array.Length);
            for (int i = 0; i < array.Length - 1; i++)
            {
                Assert.IsTrue(sortedArray[i].CompareTo(sortedArray[i + 1]) <= 0);
            }
        }
    }
}