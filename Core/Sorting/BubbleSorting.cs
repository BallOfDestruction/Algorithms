using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace Core.Sorting
{
    public class BubbleSorting<T> : ISorting<T>
        where T : IComparable, IComparable<T>
    {
        public string Name => "Bubble sorting";
        
        public IEnumerable<T> DoSort(IEnumerable<T> items)
        {
            var arrayItems = items.ToArray();

            var itemsCount = arrayItems.Length;

            for (var i = 0; i < itemsCount; i++)
                for (var j = 0; j < itemsCount; j++)
                    if (arrayItems[i].CompareTo(arrayItems[j]) < 0)
                        SwapItems(arrayItems, i, j);

            return arrayItems.ToList();
        }


        private void SwapItems([NotNull] T[] items, int firstPosition, int secondPosition)
        {
            var firstItem = items[firstPosition];
            items[firstPosition] = items[secondPosition];
            items[secondPosition] = firstItem;
        }
    }
}