using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using go2grocery_1; 

namespace UnitTestforTrackingFeature
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SalesForm salesTest = new SalesForm();
            
            int quantity = 10;
            int currentQuantity = 5;
            int expectedQuantity = -5;

            int finalQuantity = salesTest.finalQuantityCalculation(quantity, currentQuantity);

            Assert.AreEqual(expectedQuantity, finalQuantity);
        }

        [TestMethod]
        public void TestMethod2()
        {
            SalesForm salesTest = new SalesForm();

            int quantity = 20;
            int currentQuantity = 5;
            int expectedQuantity = -15;

            int finalQuantity = salesTest.finalQuantityCalculation(quantity, currentQuantity);

            Assert.AreEqual(expectedQuantity, finalQuantity);
        }

        [TestMethod]
        public void TestMethod3()
        {
            SalesForm salesTest = new SalesForm();

            int quantity = 100;
            int currentQuantity = 200;
            int expectedQuantity = 100;

            int finalQuantity = salesTest.finalQuantityCalculation(quantity, currentQuantity);

            Assert.AreEqual(expectedQuantity, finalQuantity);
        }

        [TestMethod]
        public void TestMethod4()
        {
            SalesForm salesTest = new SalesForm();

            int quantity = 0;
            int currentQuantity = 5;
            int expectedQuantity = 5;

            int finalQuantity = salesTest.finalQuantityCalculation(quantity, currentQuantity);

            Assert.AreEqual(expectedQuantity, finalQuantity);
        }

        [TestMethod]
        public void TestMethod5()
        {
            SalesForm salesTest = new SalesForm();

            int quantity = 0;
            int currentQuantity = 0;
            int expectedQuantity = 0;

            int finalQuantity = salesTest.finalQuantityCalculation(quantity, currentQuantity);

            Assert.AreEqual(expectedQuantity, finalQuantity);
        }

        [TestMethod]
        public void TestMethod6()
        {
            SalesForm salesTest = new SalesForm();

            int quantity = -10;
            int currentQuantity = -5;
            int expectedQuantity = 5;

            int finalQuantity = salesTest.finalQuantityCalculation(quantity, currentQuantity);

            Assert.AreEqual(expectedQuantity, finalQuantity);
        }

        [TestMethod]
        public void TestMethod7()
        {
            SalesForm salesTest = new SalesForm();

            int quantity = 30;
            int currentQuantity = 35;
            int expectedQuantity = 5;

            int finalQuantity = salesTest.finalQuantityCalculation(quantity, currentQuantity);

            Assert.AreEqual(expectedQuantity, finalQuantity);
        }

        [TestMethod]
        public void TestMethod8()
        {
            SalesForm salesTest = new SalesForm();

            int quantity = 400;
            int currentQuantity = 20;
            int expectedQuantity = -380;

            int finalQuantity = salesTest.finalQuantityCalculation(quantity, currentQuantity);

            Assert.AreEqual(expectedQuantity, finalQuantity);
        }

        [TestMethod]
        public void TestMethod9()
        {
            SalesForm salesTest = new SalesForm();

            int quantity = -0;
            int currentQuantity = 0;
            int expectedQuantity = 0;

            int finalQuantity = salesTest.finalQuantityCalculation(quantity, currentQuantity);

            Assert.AreEqual(expectedQuantity, finalQuantity);
        }

        [TestMethod]
        public void TestMethod10()
        {
            SalesForm salesTest = new SalesForm();

            int quantity = 50;
            int currentQuantity = 5;
            int expectedQuantity = -45;

            int finalQuantity = salesTest.finalQuantityCalculation(quantity, currentQuantity);

            Assert.AreEqual(expectedQuantity, finalQuantity);
        }

        [TestMethod]
        public void TestMethod11()
        {
            SalesForm salesTest = new SalesForm();

            int quantity = 100;
            int currentQuantity = 100;
            int expectedQuantity = 0;

            int finalQuantity = salesTest.finalQuantityCalculation(quantity, currentQuantity);

            Assert.AreEqual(expectedQuantity, finalQuantity);
        }

        [TestMethod]
        public void TestMethod12()
        {
            SalesForm salesTest = new SalesForm();

            int quantity = -10000;
            int currentQuantity = -10000;
            int expectedQuantity = 0;

            int finalQuantity = salesTest.finalQuantityCalculation(quantity, currentQuantity);

            Assert.AreEqual(expectedQuantity, finalQuantity);
        }

        [TestMethod]
        public void TestMethod13()
        {
            SalesForm salesTest = new SalesForm();

            int quantity = 4000;
            int currentQuantity = 4000;
            int expectedQuantity = 0;

            int finalQuantity = salesTest.finalQuantityCalculation(quantity, currentQuantity);

            Assert.AreEqual(expectedQuantity, finalQuantity);
        }

        [TestMethod]
        public void TestMethod14()
        {
            SalesForm salesTest = new SalesForm();

            int quantity = -10000;
            int currentQuantity = 0;
            int expectedQuantity = 10000;

            int finalQuantity = salesTest.finalQuantityCalculation(quantity, currentQuantity);

            Assert.AreEqual(expectedQuantity, finalQuantity);
        }
        [TestMethod]
        public void TestMethod15()
        {
            SalesForm salesTest = new SalesForm();

            int quantity = 0;
            int currentQuantity = -10000;
            int expectedQuantity = -10000;

            int finalQuantity = salesTest.finalQuantityCalculation(quantity, currentQuantity);

            Assert.AreEqual(expectedQuantity, finalQuantity);
        }

        [TestMethod]
        public void TestMethod16()
        {
            SalesForm salesTest = new SalesForm();

            int quantity = -10000;
            int currentQuantity = 0;
            int expectedQuantity = 10000;

            int finalQuantity = salesTest.finalQuantityCalculation(quantity, currentQuantity);

            Assert.AreEqual(expectedQuantity, finalQuantity);
        }

        [TestMethod]
        public void TestMethod17()
        {
            SalesForm salesTest = new SalesForm();

            int quantity = 66;
            int currentQuantity = 36;
            int expectedQuantity = -30;

            int finalQuantity = salesTest.finalQuantityCalculation(quantity, currentQuantity);

            Assert.AreEqual(expectedQuantity, finalQuantity);
        }

        [TestMethod]
        public void TestMethod18()
        {
            SalesForm salesTest = new SalesForm();

            int quantity = 100;
            int currentQuantity = 5;
            int expectedQuantity = -95;

            int finalQuantity = salesTest.finalQuantityCalculation(quantity, currentQuantity);

            Assert.AreEqual(expectedQuantity, finalQuantity);
        }

        [TestMethod]
        public void TestMethod19()
        {
            SalesForm salesTest = new SalesForm();

            int quantity = 44;
            int currentQuantity = 22;
            int expectedQuantity = -22;

            int finalQuantity = salesTest.finalQuantityCalculation(quantity, currentQuantity);

            Assert.AreEqual(expectedQuantity, finalQuantity);
        }

        [TestMethod]
        public void TestMethod20()
        {
            SalesForm salesTest = new SalesForm();

            int quantity = 600;
            int currentQuantity = 500;
            int expectedQuantity = -100;

            int finalQuantity = salesTest.finalQuantityCalculation(quantity, currentQuantity);

            Assert.AreEqual(expectedQuantity, finalQuantity);
        }

    }
}
