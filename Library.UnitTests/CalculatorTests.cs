using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Library.UnitTests;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void Divide()
    {
        var calculator = new Mock<ICalculator>();

        calculator.Setup(x => x.Divide(It.IsAny<decimal>(), It.IsAny<decimal>())).Returns(100);

        Assert.AreEqual(100, calculator.Object.Divide(1000, 10));
    }

    [TestMethod]
    [ExpectedException(typeof(DivideByZeroException))]
    public void DivideByZeroException()
    {
        var calculator = new Mock<ICalculator>();

        calculator.Setup(x => x.Divide(It.IsAny<decimal>(), 0)).Throws(new DivideByZeroException());

        calculator.Object.Divide(1000, 0);
    }
}
