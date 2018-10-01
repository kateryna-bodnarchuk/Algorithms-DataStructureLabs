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
            Console.WriteLine("Unsorted array : " + sourceArrayString);

            Console.ReadLine();
            QuickSortLogic.MyQuickSort(source);
            string sortedArrayString = string.Join(" ", source);
            Console.WriteLine("Sorted array : " + sortedArrayString);
            Console.ReadKey();
        }
    }
}
