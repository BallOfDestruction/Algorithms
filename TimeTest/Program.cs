using System;
using Core.Generators;
using Core.Sorting;

namespace TimeTest
{
    internal class Program
    {
        private const int CountWorks = 10;
        private const int ItemsCount = 10000;
        
        public static void Main(string[] args)
        {
            Console.WriteLine($"Count: {CountWorks}");
            
            var stopWatch = new WorkStopWatch();

            Console.WriteLine();
            Console.WriteLine($"Sorting. Items count: {ItemsCount}");
            
            var randomGenerator = new IntRandomGenerator();
            
            var bubbleSorting = new BubbleSorting<int>();
            var time = stopWatch.CheckTime(() => randomGenerator.Generate(ItemsCount), ints => bubbleSorting.DoSort(ints), CountWorks);
            Console.WriteLine($"{bubbleSorting.Name}: {time} ms");

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
