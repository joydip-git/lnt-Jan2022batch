using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculationLibrary;
using System;
using System.Diagnostics;

namespace CalculationLibraryTestProject
{
    [TestClass]
    public class CalculationTest
    {
        static Calculation calc;
        static TestContext _context;

        //public CalculationTest()
        //{
        //    Debug.WriteLine("calc created");
        //    calc = new Calculation();
        //}

        /**
         * this function will be executed before every test case
         
        [TestInitialize]
        public void Create()
        {
            Debug.WriteLine("calc initialized");
            calc = new Calculation();
        }
        */
        /**
         * this function will be executed after every test case
         
        [TestCleanup]
        public void Destroy()
        {
            Debug.WriteLine("calc nullified");
            calc = null;
        }
        */

        /**
         * this function will be executed before all the test cases
         */
        [ClassInitialize]
        public static void Init(TestContext testContext)
        {
            _context = testContext;
            //_context.WriteLine("in the Init method");
            _context.WriteLine($"currently running: {_context.TestName} case");
            calc = new Calculation();
        }

        /**
         * this function will be executed after all the test cases
         */
        [ClassCleanup]
        public static void Clean()
        {
            Debug.WriteLine("calculation nullified");
            calc = null;
        }

        [TestMethod]
        public void DividePositiveTest()
        {
            Debug.WriteLine("inside divide positive test case");
            int first = 10;
            int second = 2;
            int expectedResult = 5;

            int actualResult = calc.Divide(first, second);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideExceptionTest()
        {
            int first = 10;
            int second = 0;
            calc.Divide(first, second);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DivideNegativeValueTest()
        {
            int first = -10;
            int second = 2;
            calc.Divide(first, second);
        }

        [TestMethod]
        public void AddPositiveTest()
        {
            Debug.WriteLine("inside add positive test case");
            int first = 2;
            int second = 3;
            int expectedResult = 5;
            int actualResult = calc.Add(first, second);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
