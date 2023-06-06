using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSolutionLibrary;
using System;

namespace ProblemSolutionTest
{
    [TestClass]
    public class FigureTests
    {
        [TestMethod]
        public void CircleTest()
        {
            Random rand = new Random();
            double radius = rand.Next(0, 30);
            Circle circle = new Circle(radius);
            Assert.AreEqual(circle.Square(), Math.PI*Math.Pow(radius, 2));
        }

        [TestMethod]
        public void TriangleTest()
        {
            Random rand = new Random();
            double[] sides = new double[3];
            for (int i = 0; i < sides.Length; i++)
                sides[i] = rand.Next(0,30);
            Triangle triangle = new Triangle(sides);
            Array.Sort(sides);
            double a = sides[0];
            double b = sides[1];
            double c = sides[2];
            double halfPerimeter = (a + b + c) / 2;
            Assert.AreEqual(triangle.Square(), Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c)));
            Assert.AreEqual(a * a + b * b == c * c, triangle.isRectangular());
        }
    }
}