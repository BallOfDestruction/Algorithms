using System;
using System.Linq;
using Core.Generators;
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
            TrySorting(new BubbleSorting<int>());
        }
        
        [Test]
        public void ShakerSorting()
        {
            TrySorting(new ShakerSorting<int>());
        }
        
        [Test]
        public void CombSorting()
        {
            TrySorting(new CombSorting<int>());
        }
                
        [Test]
        public void InsertionSorting()
        {
            TrySorting(new InsertionSorting<int>());
        }

        [Test]
        public void SmallIntersectionSorting()
        {
            var test = new SortingRandomTestCase(new InsertionSorting<int>());
            
            var sorting = new InsertionSorting<byte>();
            var intGenerator = new ByteRandomGenerator();
            var random = intGenerator.Generate(10);
            var items = sorting.DoSort(random);

            var str = items.Aggregate("", (s, i) => s + "  " + i);
            Console.WriteLine(str);
            
            Assert.IsTrue(test.Check(items));
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