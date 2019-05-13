using System.Collections.Generic;

namespace Core.Generators
{
    public interface IGenerator<T>
    {
        IEnumerable<T> Generate(int countItems);
    }
}