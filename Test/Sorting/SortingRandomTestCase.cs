using System.Collections.Generic;
using System.Linq;
using Core.Generators;
using Core.Sorting;
using JetBrains.Annotations;

namespace Test.Sorting
{
    public class SortingRandomTestCase
    {
        [NotNull] private readonly ISorting<int> _sorting;

        public SortingRandomTestCase([NotNull] ISorting<int> sorting)
        {
            _sorting = sorting;
        }

        public bool CheckSorting(int itemsCount)
        {
            var items = new IntRandomGenerator().Generate(itemsCount);

            var sortedItems = _sorting.DoSort(items);

            return CheckWorking(sortedItems);
        }

        private bool CheckWorking([NotNull] IEnumerable<int> sortedItems)
        {
            var items = sortedItems.ToArray();
            for (var i = 0; i < items.Length - 1; i++)
                if (items[i] > items[i + 1])
                    return false;

            return true;
        }
    }
}