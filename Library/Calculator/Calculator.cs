namespace Library;

public sealed class Calculator : ICalculator
{
    public decimal Divide(decimal left, decimal right) => left / right;

    public decimal Multiply(decimal left, decimal right) => left * right;

    public decimal Subtract(decimal left, decimal right) => left - right;

    public decimal Sum(decimal left, decimal right) => left + right;
}
