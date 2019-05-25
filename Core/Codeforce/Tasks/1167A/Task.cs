using System;

namespace Core.Codeforce.Tasks._1167A
{
    class Program
    {
        public static void Main(string[] args)
        {
            var task = new Task();

            Console.ReadLine();

            string line;
            
            while (!string.IsNullOrEmpty(line = Console.ReadLine())) 
                Console.WriteLine(task.Solve(int.Parse(line), Console.ReadLine()) ? "YES" : "NO");
        }
    }
    
    public class Task
    {
        public bool Solve(int length, string inputString)
        {
            var index = inputString.IndexOf("8");
            return length >= 11 && index != -1 && length - index >= 11;
        }
    }
}