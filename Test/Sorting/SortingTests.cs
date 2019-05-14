using Core.Sorting;
using NUnit.Framework;

namespace Test.Sorting
{
    [TestFixture]
    public class SortingTests
    {
        private const int ItemsCount = 10000;
        
        [Test]
        public void BubbleSorting()
        {
            var bubbleSorting = new BubbleSorting<int>();
            
            var test = new SortingRandomTestCase(bubbleSorting);
            
            Assert.IsTrue(test.CheckSorting(ItemsCount));
        }
        
        [Test]
        public void ShakerSorting()
        {
            var bubbleSorting = new ShakerSorting<int>();
            
            var test = new SortingRandomTestCase(bubbleSorting);
            
            Assert.IsTrue(test.CheckSorting(ItemsCount));
        }
    }
}