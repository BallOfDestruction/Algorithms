using System;

namespace Core.Sorting
{
    public class InsertionSorting<T> : ISorting<T>
        where T : IComparable, IComparable<T>
    {
        public string Name => "Insertion sorting";

        public T[] DoSort(T[] items) { return items; }
    }
}
