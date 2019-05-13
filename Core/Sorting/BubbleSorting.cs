using System.Collections.Generic;
using System.Linq;

namespace Core.Sorting
{
    public class BubbleSorting<T> : ISorting<T>
    {
        public IEnumerable<T> DoSort(IEnumerable<T> items)
        {
            var arrayItems = items.ToArray();

            return arrayItems.ToList();
        }
    }
}