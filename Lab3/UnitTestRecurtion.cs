using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab3
{
    ///<summary>
    //Описати рекурсивну функцію множення двох чисел, використовуючи лише операцію додавання.
    ///</summary>

    [TestClass]
    public class UnitTestRecurtion
    {
        int Product(int count, int core)
        {
            if (count == 0) return 0;
            else return core + Product(--count, core);
        }

        [TestMethod]
        public void TestMethod1()
        {
            var a = Product(7, 8);
            Assert.IsTrue(a.Equals(56));
        }
    }
}
