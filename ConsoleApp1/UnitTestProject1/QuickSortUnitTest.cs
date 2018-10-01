using System;
using System.Collections.Generic;
using System.Linq;
using Lab1Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab1
{
    [TestClass]
    public class QuickSortUnitTest
    {
        [TestMethod]
        public void TestQuickSort()
        {
            var random = new Random(0);
            for (int experiment = 0; experiment < 10; experiment++)
            {
                var source = Enumerable.Range(1, 10).Select(_ => random.Next(10)).ToArray();
                var a = source.ToArray();
                QuickSortLogic.MyQuickSort(a);
                var b = source.ToList();
                b.Sort();
                Assert.IsTrue(a.SequenceEqual(b));
            }
        }
    }
}

