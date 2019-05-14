using Core.Sorting;
using JetBrains.Annotations;
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
            
            TrySorting(bubbleSorting);
        }
        
        [Test]
        public void ShakerSorting()
        {
            var bubbleSorting = new ShakerSorting<int>();
            
            TrySorting(bubbleSorting);
        }
        
        [Test]
        public void CombSorting()
        {
            var bubbleSorting = new CombSorting<int>();
            
            TrySorting(bubbleSorting);
        }
                
        [Test]
        public void InsertionSorting()
        {
            var bubbleSorting = new InsertionSorting<int>();
            
            TrySorting(bubbleSorting);
        }

        private void TrySorting([NotNull] ISorting<int> sorting)
        {
            var test = new SortingRandomTestCase(sorting);
            
            Assert.IsTrue(test.CheckSorting(ItemsCount));
            
            Assert.IsTrue(test.CheckSorting(3));
            
            Assert.IsTrue(test.CheckSorting(2));
            
            Assert.IsTrue(test.CheckSorting(1));
            
            Assert.IsTrue(test.CheckSorting(0));
        }
    }
}