
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Claims;

namespace TestCalc
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSum()
        {

            //arrange
            var x = 10;
            var y = 1;
            var calc = new Clalc();

            //act
            var result = calc.Sum(x, y);

            //assert
            Assert.AreEqual(result, 11);

        }
        [TestMethod]
        public void TestSub()
        {

            //arrange
            var x = 10;
            var y = 1;
            var calc = new Clalc();

            //act
            var result = calc.Sub(x, y);

            //assert
            Assert.AreEqual(result, 9);

        }
    }
}
