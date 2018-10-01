using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab4
{
    class UnitTestBinarySearch
    {
        
    }
    [TestMethod]
    public void TestMethod1()
    {
        var a = new int[] { 2, 5, 8, 10, 14, 25 };
        Assert.IsTrue(BinarySearch(a, 10));
    }
}
