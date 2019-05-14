using System;
using System.Collections.Generic;
using System.Linq;
using Core.Sorting;
using JetBrains.Annotations;

namespace Test.Sorting
{
    public class SortingTestCase<T> 
        where T : IComparable, IComparable<T>
    {
        [NotNull] public ISorting<T> Sorting { get; }

        public SortingTestCase([NotNull] ISorting<T> sorting)
        {
            Sorting = sorting;
        }   
        
        public bool Check([NotNull] IEnumerable<T> sortedItems)
        {
            var items = sortedItems.ToArray();
            for (var i = 0; i < items.Length - 1; i++)
                if (items[i].CompareTo(items[i + 1]) > 0)
                    return false;

            return true;
        }
    }
}