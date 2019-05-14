using System;
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
        
        public bool Check<T>([NotNull] IEnumerable<T> sortedItems)
            where T : IComparable, IComparable<T>
        {
            var items = sortedItems.ToArray();
            for (var i = 0; i < items.Length - 1; i++)
                if (items[i].CompareTo(items[i + 1]) > 0)
                    return false;

            return true;
        }
    }
}