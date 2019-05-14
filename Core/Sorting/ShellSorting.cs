using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Core.Sorting
{
    public class ShellSorting<T> : ISorting<T> 
        where T : IComparable, IComparable<T>
    {
        public string Name => "Shell sort";

        public T[] DoSort(T[] items)
        {
            var itemsCount = items.Length;
            var gaps = GetGaps(itemsCount);

            foreach (var gap in gaps)
            {
                for (var i = gap; i < itemsCount; i++)
                {
                    var item = items[i];
                    var j = i;
                    var k = j - gap;
                    for (; j >= gap && item.CompareTo(items[k]) < 0; k -= gap)
                    {
                        items[j] = items[k];
                        j = k;
                    }

                    items[j] = item;
                }
            }

            return items;
        }

        [NotNull]
        private List<int> GetGaps(int itemsCount)
        {
            var gaps = new List<int>();
            var gap = itemsCount;
            while (gap > 1)
            {
                gaps.Add(gap);
                gap /= 2;
            }
            
            gaps.Add(1);
            
            return gaps;
        }

        [NotNull]
        private List<int> GetHibbardGaps(int itemCount)
        {
            var gaps = new List<int>();
            var n = 1;
            while (true)
            {
                var gap = (int) Math.Pow(2, n) - 1;
                if (gap > itemCount)
                    break;
                
                gaps.Add(gap);
                n++;
            }

            gaps.Reverse();
            
            return gaps;
        }
    }
}
