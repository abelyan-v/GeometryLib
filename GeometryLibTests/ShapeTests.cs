using GeometryLib;
using Xunit;

namespace GeometryLibTests
{
    public class ShapeTests
    {
        [Fact]
        public void Circle_WithValidRadius_ShouldReturnCorrectArea()
        {
            // Arrange
            var circle = new Circle(5);

            // Act
            double area = circle.GetArea();

            // Assert
            Assert.Equal(Math.PI * 25, area, 5);
        }

        [Fact]
        public void Triangle_WithValidSides_ShouldReturnCorrectArea()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            double area = triangle.GetArea();

            // Assert
            Assert.Equal(6, area, 5);
        }

        [Fact]
        public void Triangle_ShouldDetectRightTriangle()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            bool isRight = triangle.IsRightTriangle();

            // Assert
            Assert.True(isRight);
        }

        [Fact]
        public void Triangle_WithInvalidSides_ShouldThrowException()
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 3));
        }

        [Fact]
        public void Circle_WithNegativeRadius_ShouldThrowException()
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() => new Circle(-5));
        }
    }
}
