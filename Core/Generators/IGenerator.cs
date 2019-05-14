namespace Core.Generators
{
    public interface IGenerator<T>
    {
        T[] Generate(int countItems);
    }
}