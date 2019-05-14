using System;

namespace Core.Sorting
{
    public class InsertionSorting<T> : ISorting<T>
        where T : IComparable, IComparable<T>
    {
        public string Name => "Insertion sorting";

        public T[] DoSort(T[] items)
        {
            var itemsCount = items.Length;

            for (var i = 1; i < itemsCount; i++)
            {
                var item = items[i];

                var j = i;
                while (j > 0 && item.CompareTo(items[j - 1]) < 0)
                    items[j] = items[--j];

                items[j] = item;
            }
            
            return items;
        }
    }
}
