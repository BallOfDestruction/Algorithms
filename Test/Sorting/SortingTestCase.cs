using System;
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
        
        public bool Check([NotNull] [ItemNotNull] T[] sortedItems)
        {
            for (var i = 0; i < sortedItems.Length - 1; i++)
                if (sortedItems[i].CompareTo(sortedItems[i + 1]) > 0)
                    return false;

            return true;
        }
    }
}