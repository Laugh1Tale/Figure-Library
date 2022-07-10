using NUnit.Framework;
using FigureLibrary;
using System;

namespace FigureLibraryTests
{
    public class CircleTests
    {
        [SetUp]
        public void Setup()
        {
            var a = new Circle(1);
            var b = new Circle(1);
            Console.WriteLine(a.CompareAreaTo(b));
        }


        [Test]
        [TestCase(2, 12.5663706144, TestName = "CircleAreaTest")]
        [TestCase(5, 78.539816339, TestName = "AnotherCircleAreaTest")]
        public void CalculateAreaTest(double r, double expected)
        {
            var circle = new Circle(r);
            Assert.AreEqual(expected, circle.CalculateArea(), 0.00000001);
        }



        [Test]
        [TestCase(3, 3, 0, TestName = "CompareSameCircles")]
        [TestCase(1, 2, -1, TestName = "FirstCircleLessThanSecond")]
        [TestCase(3, 1, 1, TestName = "FirstCircleMoreThanSecond")]
        public void CompareTriangleAreas(double r1, double r2,  int expected)
        {
            var firstCircle = new Circle(r1);
            var secondCircle = new Circle(r2);
            Assert.AreEqual(expected, firstCircle.CompareAreaTo(secondCircle));
        }


        [Test]
        public void CheckNonExistentCircle()
        {
            try
            {
                var Circle = new Circle(-5);
                Assert.Fail("Expected exception, but not got it");
            }
            catch (Exception ex)
            {
                var expectedEx = new ArgumentException("A circle with such radius does not exist.");
                Assert.IsTrue(ex.GetType() == expectedEx.GetType());
                Assert.IsTrue(ex.Message == ex.Message);
            }
        }
    }
}