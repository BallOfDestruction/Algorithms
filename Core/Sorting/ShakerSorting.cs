using System;

namespace Core.Sorting
{
    public class ShakerSorting<T> : ISorting<T>
        where T : IComparable, IComparable<T>
    {
        public string Name => "Shaker sorting";

        public T[] DoSort(T[] items)
        {
            return items;
        }
    }
}