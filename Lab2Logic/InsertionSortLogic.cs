using System;

namespace Lab2Logic
{
    public static class InsertionSortLogic
    {
        static void Swap(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }

        public static void Sort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i; j < a.Length; j++)
                {
                    if (a[j] < a[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    Swap(a, i, minIndex);
                }
            }
        }
    }
}
