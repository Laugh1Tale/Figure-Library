using NUnit.Framework;
using FigureLibrary;
using System;

namespace FigureLibraryTests
{
    public class TriangleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(3, 4, 5, true, TestName = "HypotenuseIsC")]
        [TestCase(4, 5, 3, true, TestName = "HypotenuseIsB")]
        [TestCase(5, 3, 4, true, TestName = "HypotenuseIsA")]
        public void IsRectangularTest(double a, double b, double c, bool expected)
        {
            var triangle = new Triangle(a, b, c);
            Assert.AreEqual(expected, triangle.isRectangular());
        }

        [Test]
        [TestCase(3, 4, 5, 6, TestName = "RectangularTriangle")]
        [TestCase(1, 1, 1, 0.43301270, TestName = "EquilateralTriangle")]
        [TestCase(0, 0, 0, 0, TestName = "ZeroTriangle")]
        public void CalculateAreaTest(double a, double b, double c, double expected)
        {
            var triangle = new Triangle(a, b, c);
            Assert.AreEqual(expected, triangle.CalculateArea(), 0.00000001);
        }



        [Test]
        [TestCase(3, 4, 5, 5, 4, 3, 0, TestName = "CompareSameTriangles")]
        [TestCase(0, 0, 0, 3, 4, 5, -1, TestName = "FirstTriangleLessThanSecond")]
        [TestCase(3, 4, 5, 0, 0, 0, 1, TestName = "FirstTriangleMoreThanSecond")]
        public void CompareTriangleAreas(double a1, double b1, double c1, double a2, double b2, double c2, int expected)
        {
            var firstTriangle = new Triangle(a1, b1, c1);
            var secondTriangle = new Triangle(a2, b2, c2);
            Assert.AreEqual(expected, firstTriangle.CompareAreaTo(secondTriangle));
        }


        [Test]
        [TestCase(1, 2, 4, TestName = "NonExistentTriangle1")]
        [TestCase(2, 4, 1, TestName = "NonExistentTriangle2")]
        [TestCase(4, 1, 2, TestName = "NonExistentTriangle3")]
        [TestCase(-1, -1, -1, TestName = "NonExistentTriangle4")]
        public void CheckNonExistentTriangle(double a, double b, double c)
        {
            try
            {
                var triangle = new Triangle(a, b, c);
                Assert.Fail("Expected exception, but not got it");
            }
            catch (Exception ex)
            {
                var expectedEx = new ArgumentException("A triangle with such sides does not exist.");
                Assert.IsTrue(ex.GetType() == expectedEx.GetType());
                Assert.IsTrue(ex.Message == ex.Message);
            }
        }
    }
}