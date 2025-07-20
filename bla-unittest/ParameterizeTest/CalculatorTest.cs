namespace ParameterizeTest;

public class CalculatorTest
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(-4, -6, -10)]
    [InlineData(-2, 2, 0)]
    [InlineData(int.MinValue, -1, int.MaxValue)]
    public void ShouldAddWith(int leftOperand, int rightOperand, int expectedValue)
    {
        var calculator = new Calculator();

        var actualValue = calculator.Add(leftOperand, rightOperand);

        Assert.Equal(expectedValue, actualValue);
    }
}

public class Calculator
{
    public int Add(int leftOperand, int rightOperand)
    {
        return leftOperand + rightOperand;
    }
}
