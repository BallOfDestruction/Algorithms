using System;
using Core.Extensions;

namespace Core.Sorting
{
    public class SelectionSorting<T> : ISorting<T> 
        where T : IComparable, IComparable<T>
    {
        public string Name => "Selection sorting";

        public T[] DoSort(T[] items)
        {
            var itemsCount = items.Length;

            for (var i = 0; i < itemsCount; i++)
            {
                var swapItem = i;
                var minItem = items[swapItem];

                for (var j = i; j < itemsCount; j++)
                {
                    var checkItem = items[j];
                    if (minItem.CompareTo(checkItem) > 0)
                    {
                        swapItem = j;
                        minItem = checkItem;
                    }
                }
                
                items.Swap(i, swapItem);
            }
            
            return items;
        }
    }
}
