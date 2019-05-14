using System;
using JetBrains.Annotations;

namespace Core.Sorting
{
    public class BubbleSorting<T> : ISorting<T>
        where T : IComparable, IComparable<T>
    {
        public string Name => "Bubble sorting";
        
        public T[] DoSort(T[] items)
        {
            var itemsCount = items.Length;

            for (var i = 0; i < itemsCount; i++)
                for (var j = 0; j < itemsCount; j++)
                    if (items[i].CompareTo(items[j]) < 0)
                        SwapItems(items, i, j);

            return items;
        }


        private void SwapItems([NotNull] T[] items, int firstPosition, int secondPosition)
        {
            var firstItem = items[firstPosition];
            items[firstPosition] = items[secondPosition];
            items[secondPosition] = firstItem;
        }
    }
}