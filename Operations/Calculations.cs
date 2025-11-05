namespace Operations;

public class Calculations
{
    /// <summary>
    /// Add two numbers
    /// </summary>
    /// <param name="num1">First number</param>
    /// <param name="num2">Second number</param>
    /// <returns>The sum of the two numbers</returns>
    public static double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    /// <summary>
    /// Subtract the second number from the first
    /// </summary>
    /// <param name="num1">First number</param>
    /// <param name="num2">Second number</param>
    /// <returns>The difference of the two numbers</returns>
    public static double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    /// <summary>
    /// Multiply two numbers
    /// </summary>
    /// <param name="num1">First number</param>
    /// <param name="num2">Second number</param>
    /// <returns>The product of the two numbers</returns>
    public static double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    /// <summary>
    /// Divide the first number by the second
    /// </summary>
    /// <param name="num1">First number (dividend)</param>
    /// <param name="num2">Second number (divisor)</param>
    /// <returns>The quotient of the two numbers</returns>
    /// <exception cref="DivideByZeroException">Thrown when num2 is zero</exception>
    public static double Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero");
        }
        return num1 / num2;
    }

    /// <summary>
    /// Calculate the remainder of dividing the first number by the second
    /// </summary>
    /// <param name="num1">First number (dividend)</param>
    /// <param name="num2">Second number (divisor)</param>
    /// <returns>The remainder of the division</returns>
    /// <exception cref="DivideByZeroException">Thrown when num2 is zero</exception>
    public static double Remainder(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero");
        }
        return num1 % num2;
    }
}
