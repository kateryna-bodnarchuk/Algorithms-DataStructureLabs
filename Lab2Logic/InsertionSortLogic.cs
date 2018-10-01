using System;

namespace Lab2Logic
{
    public class InsertionSortLogic
    {
        public int SwapCount = 0;
        public int ComparisonCount = 0;

        void Swap(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
            SwapCount++;
        }
        public void Sort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i; j < a.Length; j++)
                {
                    if (CompareLess(a[j], a[minIndex]))
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
        bool CompareLess(int a, int b)
        {
            ComparisonCount++;
            return a < b;
        }
    }
}
