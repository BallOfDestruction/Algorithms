using Core.Generators;
using Core.Sorting;
using JetBrains.Annotations;

namespace Test.Sorting
{
    public class SortingRandomTestCase : SortingTestCase
    {
        public SortingRandomTestCase([NotNull] ISorting<int> sorting) : base(sorting)
        {
        }

        public bool CheckSorting(int itemsCount)
        {
            var items = new IntRandomGenerator().Generate(itemsCount);

            var sortedItems = Sorting.DoSort(items);

            return Check(sortedItems);
        }
    }
}