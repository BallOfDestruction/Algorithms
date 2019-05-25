using System;
using Core.Extensions;

namespace Core.Sorting
{
    public class BubbleSorting<T> : ISorting<T>
        where T : IComparable, IComparable<T>
    {
        public string Name => "Bubble sorting";
        
        public T[] DoSort(T[] items)
        {
            var itemsCount = items.Length;

            for (var i = itemsCount - 1; i > 0; i--)
            {
                for (var j = 0; j < i; j++)
                    if (items[j].CompareTo(items[j + 1]) > 0)
                        items.Swap(j, j + 1);
            }

            return items;
        }
    }
}