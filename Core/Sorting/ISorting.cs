using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Core.Sorting
{
    public interface ISorting<T>
        where T : IComparable, IComparable<T>
    {
        [NotNull] 
        IEnumerable<T> DoSort([NotNull] [ItemNotNull] IEnumerable<T> items);
        
        string Name { get; }
    }
}