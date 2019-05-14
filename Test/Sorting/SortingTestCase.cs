using System.Collections.Generic;
using System.Linq;
using Core.Sorting;
using JetBrains.Annotations;

namespace Test.Sorting
{
    public abstract class SortingTestCase
    {
        [NotNull] public ISorting<int> Sorting { get; }

        public SortingTestCase([NotNull] ISorting<int> sorting)
        {
            Sorting = sorting;
        }   
        
        protected bool Check([NotNull] IEnumerable<int> sortedItems)
        {
            var items = sortedItems.ToArray();
            for (var i = 0; i < items.Length - 1; i++)
                if (items[i] > items[i + 1])
                    return false;

            return true;
        }
    }
}