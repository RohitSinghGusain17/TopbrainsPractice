using System;

namespace GenericArrayMerge
{
    public class Program
    {
        public static void Main()
        {
            int[] a = { 1, 3, 5, 7 };
            int[] b = { 2, 4, 6, 8 };

            int[] merged = MergeSortedArrays(a, b);

            Console.WriteLine("Merged Array:");
            foreach (var item in merged)
            {
                Console.Write(item + " ");
            }
        }

        public static T[] MergeSortedArrays<T>(T[] a, T[] b)
            where T : IComparable<T>
        {
            if (a == null)
                throw new ArgumentNullException(nameof(a));

            if (b == null)
                throw new ArgumentNullException(nameof(b));

            int n = a.Length;
            int m = b.Length;

            T[] merged = new T[n + m];

            int i = 0, j = 0, k = 0;

            while (i < n && j < m)
            {
                if (a[i].CompareTo(b[j]) <= 0)
                {
                    merged[k++] = a[i++];
                }
                else
                {
                    merged[k++] = b[j++];
                }
            }
            while (i < n)
            {
                merged[k++] = a[i++];
            }
            while (j < m)
            {
                merged[k++] = b[j++];
            }
            return merged;
        }
    }
}