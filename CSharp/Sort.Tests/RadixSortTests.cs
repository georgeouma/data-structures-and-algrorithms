using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sort.Tests
{
    [TestClass()]
    public class RadixSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            int[] array = new int[] { 536, 484, 343, 287, 198 };
            var sortedArray = new RadixSort().Sort(array);

            Assert.AreEqual(sortedArray.Length, array.Length);
            for (int i = 0; i < array.Length - 1; i++)
            {
                Assert.IsTrue(sortedArray[i].CompareTo(sortedArray[i + 1]) <= 0);
            }
        }
    }
}