using System;

namespace TimeTest
{
    internal class Program
    {
        private const int WorksCount = 10;
        private const int ItemsCount = 10000;
        
        public static void Main(string[] args)
        {
            var sortingTimeTest = new SortingTimeTest();
            sortingTimeTest.Do(ItemsCount, WorksCount);

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
