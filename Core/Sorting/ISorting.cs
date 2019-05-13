using System.Collections.Generic;
using JetBrains.Annotations;

namespace Core.Sorting
{
    public interface ISorting<T>
    {
        [NotNull] 
        IEnumerable<T> DoSort([NotNull] IEnumerable<T> items);
    }
}