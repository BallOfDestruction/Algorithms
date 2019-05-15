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
            SimpleTrySorting(new BubbleSorting<byte>());
            TrySorting(new BubbleSorting<int>());
        }
        
        [Test]
        public void ShakerSorting()
        {
            SimpleTrySorting(new ShakerSorting<byte>());
            TrySorting(new ShakerSorting<int>());
        }
        
        [Test]
        public void CombSorting()
        {
            SimpleTrySorting(new CombSorting<byte>());
            TrySorting(new CombSorting<int>());
        }
                
        [Test]
        public void InsertionSorting()
        {
            SimpleTrySorting(new InsertionSorting<byte>());
            TrySorting(new InsertionSorting<int>());
        }

        [Test]
        public void ShellSorting()
        {
            SimpleTrySorting(new ShellSorting<byte>());
            TrySorting(new ShellSorting<int>());
        }
        
        [Test]
        public void GnomeSorting()
        {
            SimpleTrySorting(new GnomeSorting<byte>());
            TrySorting(new GnomeSorting<int>());
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

        private void SimpleTrySorting([NotNull] ISorting<byte> sorting)
        {
            var intGenerator = new ByteRandomGenerator();
            var random = intGenerator.Generate(10);
            var items = sorting.DoSort(random);

            var str = items.Aggregate("", (s, i) => s + "  " + i);
            Console.WriteLine(str);
            
            var testCase = new SortingTestCase<byte>(sorting);
            Assert.IsTrue(testCase.Check(items));
        }
    }
}