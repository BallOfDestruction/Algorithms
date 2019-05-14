using System;

namespace Core.Sorting
{
    public class ShellSorting<T> : ISorting<T> 
        where T : IComparable, IComparable<T>
    {
        public string Name => "Shell sort";

        public T[] DoSort(T[] items) { return items; }
    }
}
