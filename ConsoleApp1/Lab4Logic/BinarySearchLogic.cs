using System;

namespace Lab4Logic
{
    public class BinarySearchLogic
    {
        bool BinarySearch(int[] a, int value)
        {
            int min = 0;
            int max = a.Length - 1;
            while (min <= max)
            {
                var middle = min + ((max - min) / 2);
                if (a[middle] > value)
                {
                    max = middle - 1;
                }
                else if (a[middle] < value)
                {
                    min = middle + 1;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

    }
}
