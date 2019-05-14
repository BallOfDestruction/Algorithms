using System;
using System.Linq;
using JetBrains.Annotations;

namespace Core.Generators
{
    public class IntRandomGenerator : IGenerator<int>
    {
        [NotNull]
        public int[] Generate(int itemsCount)
        {
            var random = new Random(DateTime.Now.Millisecond);

            return Enumerable.Range(0, itemsCount).Select(w => random.Next(0, 255)).ToArray();
        }
    }
}
