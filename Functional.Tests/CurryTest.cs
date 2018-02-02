using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Functional.Tests
{
    [TestClass]
    public class CurryTest
    {
        [TestMethod]
        public void TestCurrying()
        {
            Func<int, int, int, int> Add = (a, b, c) => a + b + c;
            var add = Add.Curried();
            Assert.AreEqual(1 + 2 + 3, add(1)(2)(3));

            int i = 0;
            Action<int, int, int, int> Counter = (a, b, c, d) => i = a - b - c - d;
            var counter = Counter.Curried();
            counter(100)(80)(10)(0);
            Assert.AreEqual(i, 10);
        }
    }
}
