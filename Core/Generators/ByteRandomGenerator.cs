using System;
using System.Linq;
using JetBrains.Annotations;

namespace Core.Generators
{
    public class ByteRandomGenerator : IGenerator<byte>
    {
        [NotNull]
        public byte[] Generate(int itemsCount)
        {
            var random = new Random(DateTime.Now.Millisecond);

            return Enumerable.Range(0, itemsCount).Select(w => (byte) random.Next(byte.MinValue, byte.MaxValue)).ToArray();
        }
    }
}