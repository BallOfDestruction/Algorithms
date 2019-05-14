using System;
using Core.Extensions;

namespace Core.Sorting
{
    public class CombSorting<T> : ISorting<T>
        where T : IComparable, IComparable<T>
    {
        public double ShrinkFactor = 1.2473309;

        public string Name => "Comb Sorting";

        public T[] DoSort(T[] items)
        {
            var itemsCount = items.Length;
            var gap = itemsCount;

            var swapped = false;

            while (gap > 1 || swapped)
            {
                if (gap > 1)
                    gap = (int) (gap / ShrinkFactor);

                swapped = false;

                for (var i = 0; i < itemsCount - gap; i++)
                {
                    var nextPosition = i + gap;
                    if (items[i].CompareTo(items[nextPosition]) > 0)
                    {
                        items.Swap(i, nextPosition);
                        swapped = true;
                    }
                }
            }

            return items;
        }
    }
}
