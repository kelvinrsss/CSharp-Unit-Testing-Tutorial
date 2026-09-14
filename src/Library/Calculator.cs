namespace Library;

/// <summary>
/// A simple calculator used as the System Under Test (SUT) for basic, numeric,
/// floating-point, and fluent-assertion examples.
/// </summary>
public class Calculator
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;

    public double Divide(double a, double b)
    {
        if (b == 0) throw new DivideByZeroException("Cannot divide by zero.");
        return a / b;
    }

    public double Power(double baseValue, double exponent) =>
        Math.Pow(baseValue, exponent);

    public double CircleArea(double radius)
    {
        if (radius < 0)
            throw new ArgumentOutOfRangeException(nameof(radius), "Radius cannot be negative.");
        return Math.PI * radius * radius;
    }

    public double SquareRoot(double value)
    {
        if (value < 0)
            throw new ArgumentOutOfRangeException(nameof(value), "Cannot take square root of a negative number.");
        return Math.Sqrt(value);
    }
}
