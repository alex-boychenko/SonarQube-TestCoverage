namespace Library;

public interface ICalculator
{
    decimal Divide(decimal left, decimal right);

    decimal Multiply(decimal left, decimal right);

    decimal Subtract(decimal left, decimal right);

    decimal Sum(decimal left, decimal right);
}
