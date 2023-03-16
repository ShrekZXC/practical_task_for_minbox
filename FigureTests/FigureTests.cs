using FiguresLibrary;

namespace FigureTests;

public class Tests
{
    [TestFixture]
    public class FigureTests
    {
        [Test]
        public void TestCircleArea()
        {
            double radius = 5;
            Circle circle = new Circle(radius);
            double expectedArea = Math.PI * radius * radius;
            Assert.AreEqual(expectedArea, circle.GetArea());
        }

        [Test]
        public void TestTriangleArea()
        {
            double firstSide = 3;
            double secondSide = 4;
            double thirdSide = 5;
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
            double expectedArea = 6;
            Assert.AreEqual(expectedArea, triangle.GetArea());
        }

        [Test]
        public void TestTriangleIsRightAngled()
        {
            double firstSide = 3;
            double secondSide = 4;
            double thirdSide = 5;
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
            Assert.IsTrue(triangle.IsRightAngled());
        }
    }
}