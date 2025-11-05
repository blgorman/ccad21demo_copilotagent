using Shouldly;

namespace Operations.Tests
{
    public class TestCalculations
    {
        [Theory]
        [InlineData(5, 3, 8)]
        [InlineData(10, 5, 15)]
        [InlineData(-5, 3, -2)]
        [InlineData(0, 0, 0)]
        [InlineData(1.5, 2.5, 4.0)]
        [InlineData(-10, -5, -15)]
        public void TestAdd(double num1, double num2, double expected)
        {
            // Act
            var result = Calculations.Add(num1, num2);

            // Assert
            result.ShouldBe(expected, $"Adding {num1} + {num2} should equal {expected}");
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(10, 5, 5)]
        [InlineData(-5, 3, -8)]
        [InlineData(0, 0, 0)]
        [InlineData(1.5, 0.5, 1.0)]
        [InlineData(-10, -5, -5)]
        public void TestSubtract(double num1, double num2, double expected)
        {
            // Act
            var result = Calculations.Subtract(num1, num2);

            // Assert
            result.ShouldBe(expected, $"Subtracting {num1} - {num2} should equal {expected}");
        }

        [Theory]
        [InlineData(5, 3, 15)]
        [InlineData(10, 5, 50)]
        [InlineData(-5, 3, -15)]
        [InlineData(0, 5, 0)]
        [InlineData(2.5, 4, 10.0)]
        [InlineData(-10, -5, 50)]
        public void TestMultiply(double num1, double num2, double expected)
        {
            // Act
            var result = Calculations.Multiply(num1, num2);

            // Assert
            result.ShouldBe(expected, $"Multiplying {num1} * {num2} should equal {expected}");
        }

        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(15, 3, 5)]
        [InlineData(-10, 5, -2)]
        [InlineData(0, 5, 0)]
        [InlineData(7.5, 2.5, 3.0)]
        [InlineData(-20, -4, 5)]
        public void TestDivide(double num1, double num2, double expected)
        {
            // Act
            var result = Calculations.Divide(num1, num2);

            // Assert
            result.ShouldBe(expected, $"Dividing {num1} / {num2} should equal {expected}");
        }

        [Theory]
        [InlineData(10, 0)]
        [InlineData(5, 0)]
        [InlineData(-10, 0)]
        [InlineData(0, 0)]
        public void TestDivideByZeroThrowsException(double num1, double num2)
        {
            // Act & Assert
            Should.Throw<DivideByZeroException>(() => Calculations.Divide(num1, num2));
        }

        [Theory]
        [InlineData(10, 3, 1)]
        [InlineData(15, 4, 3)]
        [InlineData(7, 5, 2)]
        [InlineData(20, 6, 2)]
        [InlineData(10.5, 3, 1.5)]
        [InlineData(-10, 3, -1)]
        public void TestRemainder(double num1, double num2, double expected)
        {
            // Act
            var result = Calculations.Remainder(num1, num2);

            // Assert
            result.ShouldBe(expected, $"Remainder of {num1} % {num2} should equal {expected}");
        }

        [Theory]
        [InlineData(10, 0)]
        [InlineData(5, 0)]
        [InlineData(-10, 0)]
        [InlineData(0, 0)]
        public void TestRemainderByZeroThrowsException(double num1, double num2)
        {
            // Act & Assert
            Should.Throw<DivideByZeroException>(() => Calculations.Remainder(num1, num2));
        }
    }
}
