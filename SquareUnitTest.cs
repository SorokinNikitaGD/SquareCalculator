using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SquareCalculatorTests
{
    [TestClass]
    public class SquareUnitTest
    {
        [TestMethod]

        // Тесты: расчет площади для треугольника,
        // круга,
        // проверка на прямоугольность,
        // проверка на существование;
        public void TestTriangleSquare_4_4_4()
        {
            //arrange
            double a = 4;
            double b = 4;
            double c = 4;
            double expected = Math.Sqrt(6 * (6 - 4) * (6 - 4) * (6 - 4));
            //act
            double actual = new SquareCalculator.Square().CountSquare(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRoundSquare_4()
        {
            //arrange
            double r = 4;
            double expected = Math.Pow(4,2) * Math.PI;
            //act
            double actual = new SquareCalculator.Square().CountSquare(r);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTriangleNOTExist_1_2_3()
        {
            //arrange
            double a = 1;
            double b = 2;
            double c = 3;
            bool expected = false;
            //act
            bool actual = new SquareCalculator.Square().IsTriangleExist(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTriangleExist_3_3_3()
        {
            //arrange
            double a = 3;
            double b = 3;
            double c = 3;
            bool expected = true;
            //act
            bool actual = new SquareCalculator.Square().IsTriangleExist(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTriangleRight_3_4_5()
        {
            //arrange
            double a = 3;
            double b = 4;
            double c = 5;
            bool expected = true;
            //act
            bool actual = new SquareCalculator.Square().IsTriangleRight(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTriangleNOTRight_3_3_3()
        {
            //arrange
            double a = 3;
            double b = 3;
            double c = 3;
            bool expected = false;
            //act
            bool actual = new SquareCalculator.Square().IsTriangleRight(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
