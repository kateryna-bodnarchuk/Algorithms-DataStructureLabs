using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using Lab2Logic;

namespace Lab2
{
    [TestClass]
    public class InsertionSortUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var random = new Random(0);
            for (int experiment = 0; experiment < 10; experiment++)
            {
                var source = Enumerable.Range(1, 10).Select(_ => random.Next(10)).ToArray();
                var a = source.ToArray();
                InsertionSortLogic.Sort(a);
                var b = source.ToList();
                b.Sort();
                Assert.IsTrue(a.SequenceEqual(b));
            }
        }
    }
}
