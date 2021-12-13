using Microsoft.VisualStudio.TestTools.UnitTesting;
using SvgGenerator;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;

namespace SvgGeneratorTests
{
    [TestClass]
    public class SvgBuilderTests
    {
        [TestMethod]
        public void CreatingOneSquareGeneratesOneRect()
        {
            Shape square1 = new Square(Color.Blue, 0, 0, 225);
            var shapeList = new List<Shape>() { square1 };
            var svgBuilder = new SvgBuilder();
            var content = svgBuilder.Build(shapeList, false);
            Assert.IsTrue(content.Contains("rect"));
            Assert.AreEqual(1, Regex.Matches(content, "rect").Count);
        }

        [TestMethod]
        public void CreatingThreeSquareGeneratesThreeRect()
        {
            Shape square1 = new Square(Color.Blue, 0, 0, 225);
            Shape square2 = new Square(Color.Red, 1, 0, 225);
            Shape square3 = new Square(Color.Green, 2, 0, 225);

            var shapeList = new List<Shape>() { square1, square2, square3 };
            var svgBuilder = new SvgBuilder();
            var content = svgBuilder.Build(shapeList, false);
            Assert.IsTrue(content.Contains("rect"));
            Assert.AreEqual(3, Regex.Matches(content, "rect").Count);
        }

        [TestMethod]

        public void CreatingOneCirclesGeneratesOneCirc()
        {
            Shape circle1 = new Circle(Color.Blue, 0, 0, 225);

            var shapeList = new List<Shape>() { circle1 };
            var svgBuilder = new SvgBuilder();
            var content = svgBuilder.Build(shapeList, false);
            Assert.IsTrue(content.Contains("circ"));
            Assert.AreEqual(1, Regex.Matches(content, "circ").Count);
        }

        [TestMethod]

        public void CreatingThreeCirclesGeneratesThreeCirc()
        {
            Shape circle1 = new Circle(Color.Blue, 0, 0, 225);
            Shape circle2 = new Circle(Color.Red, 1, 0, 225);
            Shape circle3 = new Circle(Color.Green, 2, 0, 225);

            var shapeList = new List<Shape>() { circle1, circle2, circle3 };
            var svgBuilder = new SvgBuilder();
            var content = svgBuilder.Build(shapeList, false);
            Assert.IsTrue(content.Contains("circ"));
            Assert.AreEqual(3, Regex.Matches(content, "circ").Count);
        }

        [TestMethod]
        public void CreatingOneSquareAndOneCircleGeneratesOneRectAndOneCirc()
        {
            Shape circle1 = new Circle(Color.Blue, 0, 0, 225);
            Shape square1 = new Square(Color.Red, 1, 0, 225);

            var shapeList = new List<Shape>() { circle1, square1 };
            var svgBuilder = new SvgBuilder();
            var content = svgBuilder.Build(shapeList, false);
            Assert.IsTrue(content.Contains("rect"));
            Assert.AreEqual(1, Regex.Matches(content, "rect").Count);
            Assert.IsTrue(content.Contains("circ"));
            Assert.AreEqual(1, Regex.Matches(content, "circ").Count);
        }

        [TestMethod]
        public void CreatingThreeSquaresAndThreeCirclesGeneratesThreeRectAndThreeCirc()
        {
            Shape circle1 = new Circle(Color.Blue, 0, 0, 225);
            Shape circle2 = new Circle(Color.Green, 1, 0, 225);
            Shape circle3 = new Circle(Color.Orange, 2, 0, 225);
            Shape square1 = new Square(Color.Red, 3, 0, 225);
            Shape square2 = new Square(Color.Yellow, 4, 0, 225);
            Shape square3 = new Square(Color.Brown, 5, 0, 225);
            var shapeList = new List<Shape>() { circle1, square1, circle2, square2, circle3, square3 };
            var svgBuilder = new SvgBuilder();
            var content = svgBuilder.Build(shapeList, false);
            Assert.IsTrue(content.Contains("rect"));
            Assert.AreEqual(3, Regex.Matches(content, "rect").Count);
            Assert.IsTrue(content.Contains("circ"));
            Assert.AreEqual(3, Regex.Matches(content, "circ").Count);
        }
    }
}
