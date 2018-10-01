using System;
using System.Linq;
using System.Collections.Generic;
using Lab1Logic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random(0);
            int[] source = Enumerable.Range(1, 10).Select(_ => random.Next(10)).ToArray();
            string sourceArrayString = string.Join(" ", source);
            Console.WriteLine("Unsorted array: " + sourceArrayString);
            Console.ReadLine();

            var sort = new QuickSortLogic();
            sort.MyQuickSort(source);
            string sortedArrayString = string.Join(" ", source);
            Console.WriteLine("Sorted array: " + sortedArrayString);
            Console.WriteLine();
            Console.WriteLine("Number of swaps: " + sort.SwapCount);
            Console.WriteLine("Number of comparisons: " + sort.ComparisonCount);
            Console.ReadKey();
        }
    }
}
