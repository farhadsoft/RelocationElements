using System;

namespace RelocationElementsTask
{
    /// <summary>
    /// Class for operations with array.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Moves all of the elements with set value to the end, preserving the order of the other elements.
        /// </summary>
        /// <param name="source">Source array.</param>
        /// <param name="value">Source value.</param>
        /// <exception cref="ArgumentNullException">Thrown when source array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when source array is empty.</exception>
        public static void MoveToTail(int[] source, int value)
        {
            if (source is null)
            {
                throw new ArgumentNullException($"Thrown when source array is null. {nameof(source)}");
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("Thrown when source array is empty.");
            }

            for (int i = source.Length - 1; i >= 0; i--)
            {
                if (source[i] == value)
                {
                    int n = i;
                    while (n < source.Length - 1)
                    {
                        int temp = source[n];
                        source[n] = source[n + 1];
                        source[n + 1] = temp;
                        n++;
                    }
                }
            }
        }
    }
}
