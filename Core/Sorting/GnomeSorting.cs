using System;
using Core.Extensions;

namespace Core.Sorting
{
    public class GnomeSorting<T> : ISorting<T>
        where T : IComparable, IComparable<T>
    {
        public string Name => "Gnome sorting";

        public T[] DoSort(T[] items)
        {
            var currentPos = 1;
            var itemsCount = items.Length;

            var lastPosition = 2;
            
            while (currentPos < itemsCount)
                if (items[currentPos].CompareTo(items[currentPos - 1]) < 0)
                {
                    items.Swap(currentPos, currentPos - 1);
                    currentPos--;
                    if (currentPos == 0)
                    {
                        currentPos = lastPosition;
                        lastPosition++;
                    }
                }
                else
                {
                    currentPos = lastPosition;
                    lastPosition++;
                }

            return items;
        }
    }
}
