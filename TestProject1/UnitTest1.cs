using Lab1;


namespace RectangleApp.Tests
{
    [TestFixture]   
    public class RectangleTests
    {
        [Test]
        public void CalculateArea_ReturnsCorrectArea()
        {
            
            double sideA = 5;
            double sideB = 3;
            Rectangle rectangle = new Rectangle(sideA, sideB);

            
            double area = rectangle.Area;

            
            Assert.That(area, Is.EqualTo(15), "Площадь рассчитана неправильно");
        }

        [Test]
        public void CalculatePerimeter_ReturnsCorrectPerimeter()
        {
            
            double sideA = 5;
            double sideB = 3;
            Rectangle rectangle = new Rectangle(sideA, sideB);

         
            double perimeter = rectangle.Perimeter;

           
            Assert.That(perimeter, Is.EqualTo(16), "Периметр рассчитан неправильно");
        }

        [Test]
        public void Area_WithNegativeSides_ThrowsException()
        {
            
            double sideA = -5;
            double sideB = 3;

            
            Assert.Throws<ArgumentException>(() => new Rectangle(sideA, sideB), "Длины сторон не могут быть отрицательными");
        }

        [Test]
        public void Perimeter_WithZeroSides_ThrowsException()
        {
            // Arrange
            double sideA = 0;
            double sideB = 3;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Rectangle(sideA, sideB), "Длины сторон не могут быть равны нулю");
        }
    }
}
