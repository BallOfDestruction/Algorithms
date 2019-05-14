using JetBrains.Annotations;

namespace Core.Extensions
{
    public static class ArrayExtension
    {
        public static void Swap<T>([NotNull] this T[] array, int positionFirst, int positionSecond)
        {
            var buffer = array[positionFirst];
            array[positionFirst] = array[positionSecond];
            array[positionSecond] = buffer;
        }
    }
}
