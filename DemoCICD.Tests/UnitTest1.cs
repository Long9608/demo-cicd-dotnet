using Xunit;
using DemoCICD;

namespace DemoCICD.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new Calculator();

        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            // Arrange
            int a = 10;
            int b = 4;

            // Act
            int result = _calculator.Subtract(a, b);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            // Arrange
            int a = 6;
            int b = 7;

            // Act
            int result = _calculator.Multiply(a, b);

            // Assert
            Assert.Equal(42, result);
        }

        [Fact]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            // Arrange
            int a = 20;
            int b = 5;

            // Act
            int result = _calculator.Divide(a, b);

            // Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            // Arrange
            int a = 10;
            int b = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
        }

        [Fact]
        public void MultipleOperations_WorkCorrectly()
        {
            // Test nhiều phép tính
            Assert.Equal(15, _calculator.Add(10, 5));
            Assert.Equal(5, _calculator.Subtract(10, 5));
            Assert.Equal(50, _calculator.Multiply(10, 5));
            Assert.Equal(2, _calculator.Divide(10, 5));
        }
    }
}