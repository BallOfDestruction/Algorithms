using System;

namespace Core.Sorting
{
    public class HeapSorting<T> : ISorting<T> 
        where T : IComparable, IComparable<T>
    {
        public string Name => "Heap sorting";

        public T[] DoSort(T[] items)
        {
            return items;
        }
    }
}
