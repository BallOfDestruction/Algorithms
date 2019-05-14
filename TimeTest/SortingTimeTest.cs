using System;
using System.Collections.Generic;
using Core.Generators;
using Core.Sorting;
using JetBrains.Annotations;

namespace TimeTest
{
    public class SortingTimeTest
    {
        [NotNull] private List<ISorting<int>> _sortings = new List<ISorting<int>>
        {
            new BubbleSorting<int>(),
            new ShakerSorting<int>(),
            new CombSorting<int>(),
            new InsertionSorting<int>(),
            new ShellSorting<int>(),
        };
        
        public void Do(int itemsCount, int worksCount)
        {
            var stopWatch = new WorkStopWatch();

            Console.WriteLine();
            Console.WriteLine("Sorting");
            Console.WriteLine($"Items count: {itemsCount}");
            Console.WriteLine($"Works count: {worksCount}");

            var randomGenerator = new IntRandomGenerator();

            foreach (var sorting in _sortings)
            {
                var time = stopWatch.CheckTime(() => randomGenerator.Generate(itemsCount),
                    ints => sorting.DoSort(ints ?? new int[0]),
                    worksCount);
            
                Console.WriteLine();
                Console.WriteLine($"{sorting.Name}:");
                Console.WriteLine($"Common time: {time} ms");
                Console.WriteLine($"Average time: {(float) time / worksCount} ms");
            }
            
            Console.WriteLine();
        }
    }
}
