using Core.Sorting;
using NUnit.Framework;

namespace Test.Sorting
{
    [TestFixture]
    public class SortingTests
    {
        private const int CountItems = 10000;
        
        [Test]
        public void BubbleSorting()
        {
            var bubbleSorting = new BubbleSorting<int>();
            
            var test = new SortingRandomTestCase(bubbleSorting);
            
            Assert.IsTrue(test.CheckSorting(CountItems));
        }
    }
}