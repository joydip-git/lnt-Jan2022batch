using NUnit.Framework;
using CalculationLibrary;
using System.Diagnostics;

namespace CalculationLibraryNUnitTests
{
    [TestFixture] //[TestClass]
    public class CalculationNUnitTest
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
        public void AddPositiveTest()
        {
            //Calculation calc = new Calculation();
            int actualResult = calc.Add(10, 2);
            Assert.AreEqual(12, actualResult);
        }

        [TestCase(10, 2, 12)] //[TestMethod] with parameters
        [TestCase(4, 2, 6)]
        public void DividePositiveTest(int a, int b, int expected)
        {
            //Calculation calc = new Calculation();
            int actualResult = calc.Add(a, b);
            Assert.AreEqual(expected, actualResult);
        }

        //[Test]
        //public void DivideExceptionTest()
        //{
        //    Calculation calc = new Calculation();
        //    calc.Divide(10, 0);

        //}
    }
}