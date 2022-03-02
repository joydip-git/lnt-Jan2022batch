using System;
using NUnit.Framework;
using CalculationLibrary;

namespace CustomNUnitTestLibrary
{
    [TestFixture]
    public class CalculationCustomTest
    {
        private Calculation calc;

        [SetUp] //[TestInitialize]
        public void Create()
        {
            //calc = new Calculation();
        }

        [TearDown] //[TestCleanUp]
        public void Destroy()
        {
            //calc = null;
        }

        [OneTimeSetUp] //[ClassInitialize]
        public void Init() { calc = new Calculation(); }

        [OneTimeTearDown] //[ClassCleanUp]
        public void Clear() { calc = null; }

        [Test] //[TestMethod]
        public void AddPositiveCustomTest()
        {
            //Calculation calc = new Calculation();
            int actualResult = calc.Add(10, 2);
            Assert.AreEqual(12, actualResult);
        }

        [TestCase(10, 2, 12)] //[TestMethod] with parameters
        [TestCase(4, 2, 6)]
        public void DividePositiveCustomTest(int a, int b, int expected)
        {
            //Calculation calc = new Calculation();
            int actualResult = calc.Add(a, b);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
