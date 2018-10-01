using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3Logic
{
    public class Algorithm
    {
        int RecursionProduct(List<int> list, int startIndex)
        {
            var current = list[startIndex];

            if (startIndex < list.Count - 1)
            {
                var next = RecursionProduct(list, startIndex + 1);
                return current * next;
            }

            else return current;

        }
    }
}
