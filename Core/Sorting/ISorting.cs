using System;
using JetBrains.Annotations;

namespace Core.Sorting
{
    public interface ISorting<T>
        where T : IComparable, IComparable<T>
    {
        string Name { get; }
        
        [NotNull] 
        T[] DoSort([NotNull] [ItemNotNull] T[] items);
    }
}