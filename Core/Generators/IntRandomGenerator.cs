using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace Core.Generators
{
    public class IntRandomGenerator : IGenerator<int>
    {
        [NotNull]
        public IEnumerable<int> Generate(int itemsCount)
        {
            var random = new Random(DateTime.Now.Millisecond);

            return Enumerable.Range(0, itemsCount).Select(w => random.Next());
        }
    }
}
