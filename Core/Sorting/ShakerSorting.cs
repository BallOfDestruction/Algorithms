using System;
using Core.Extensions;

namespace Core.Sorting
{
    public class ShakerSorting<T> : ISorting<T>
        where T : IComparable, IComparable<T>
    {
        public string Name => "Shaker sorting";

        public T[] DoSort(T[] items)
        {
            var itemsCount = items.Length;

            var startPosition = 0;
            var endPosition = itemsCount;

            while (startPosition < endPosition)
            {
                for (var i = startPosition; i < endPosition - 1; i++)
                    if (items[i].CompareTo(items[i + 1]) > 0)
                        items.Swap(i, i + 1);

                endPosition--;
                
                for (var i = endPosition - 1; i > startPosition; i--)
                    if (items[i].CompareTo(items[i - 1]) < 0)
                        items.Swap(i, i - 1);

                startPosition++;
            }

            return items;
        }
    }
}