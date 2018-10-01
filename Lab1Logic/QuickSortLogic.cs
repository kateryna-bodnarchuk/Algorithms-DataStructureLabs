using System;

namespace Lab1Logic
{
    public static class QuickSortLogic
    {
        public static void MyQuickSort(int[] a)
        {
            Sort(a, 0, a.Length - 1);
        }
        static void Sort(int[] a, int i, int j)
        {
            if (i < j)
            {
                int q = SortPart(a, i, j);
                Sort(a, i, q - 1);
                Sort(a, q + 1, j);
            }
        }
        static int SortPart(int[] a, int i, int j)
        {
            int x = a[j];
            int minValue = i - 1;
            for (int k = i; k < j; k++)
            {
                if (a[k] <= x)
                {
                    minValue++;
                    Swap(a, k, minValue);
                }
            }
            Swap(a, j, minValue + 1);
            return minValue + 1;
        }
        static void Swap(int[] a, int k, int minValue)
        {
            int temp = a[k];
            a[k] = a[minValue];
            a[minValue] = temp;
        }
    }
}

