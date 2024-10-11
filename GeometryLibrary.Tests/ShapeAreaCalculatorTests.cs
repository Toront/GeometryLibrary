using Xunit;
using GeometryLibrary;

namespace GeometryLibrary.Tests
{
    public class ShapeAreaCalculatorTests
    {
        [Fact]
        public void Circle_Area_Calculation()
        {
            var circle = new Circle(5);
            Assert.Equal(Math.PI * 25, circle.CalculateArea(), 5);
        }

        [Fact]
        public void Triangle_Area_Calculation()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.Equal(6, triangle.CalculateArea());
        }

        [Fact]
        public void Triangle_IsRightTriangle()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightTriangle());

            triangle = new Triangle(5, 5, 5);
            Assert.False(triangle.IsRightTriangle());
        }

        [Theory]
        [InlineData(-1)]
        public void Circle_Invalid_Radius_Throws_Exception(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(3, 4, 5)]
        public void Triangle_Valid_Sides(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            Assert.NotNull(triangle);
        }

        [Theory]
        [InlineData(1, 1, 3)]
        [InlineData(1, 2, 3)]
        public void Triangle_Invalid_Sides_Throws_Exception(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }
    }
}