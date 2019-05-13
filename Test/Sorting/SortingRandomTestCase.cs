using System;
using System.Collections.Generic;
using System.Linq;
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
            var items = GenerateItems(itemsCount);

            var sortedItems = _sorting.DoSort(items);

            return CheckWorking(sortedItems);
        }

        [NotNull]
        private IEnumerable<int> GenerateItems(int itemsCount)
        {
            var random = new Random(DateTime.Now.Millisecond);

            return Enumerable.Range(0, itemsCount).Select(w => random.Next());
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