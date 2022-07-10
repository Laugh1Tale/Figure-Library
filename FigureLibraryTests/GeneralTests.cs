using NUnit.Framework;
using FigureLibrary;
using System.Collections.Generic;
using System;

namespace FigureLibraryTests
{
    public class GeneralTests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        [TestCase(10)]
        public void CalculateAreaWithoutTypeKnowledge(int numberOfFigures)
        {
            var figures = new List<Figure>();
            var expectedAreas = new double[numberOfFigures];
            for (var i = 0; i < numberOfFigures; i++)
                figures.Add(i % 2 == 0 ? new Circle(0) : new Triangle(0, 0, 0));
            var areas = new List<double>();
            foreach (var figure in figures)
                areas.Add(figure.CalculateArea());

            Assert.AreEqual(expectedAreas.Length, areas.Count);
            Assert.AreEqual(expectedAreas, areas.ToArray());
        }


        [Test]
        [TestCase(0, 3, 4, 5, -1, TestName = "CircleAreLessThanTriangle")]
        [TestCase(5, 0, 0, 0, 1, TestName = "TriangleAreLessThanCircle")]
        public void CompareAreaOfTwoFigures(int radius, int a, int b, int c, int expectedResult)
        {
            var triangle = new Triangle(a, b, c);
            var circle = new Circle(radius);
            Assert.AreEqual(circle.CompareAreaTo(triangle), expectedResult);
        }


        [Test]
        public void CompareAreaOfTwoFiguresWithSameArea()
        {
            var triangle = new Triangle(3, 4, 5);
            var circle = new Circle(Math.Sqrt(6 / Math.PI));
            Assert.AreEqual(circle.CompareAreaTo(triangle), 0);
        }
    }
}