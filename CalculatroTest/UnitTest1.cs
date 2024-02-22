namespace _16._7._1.Tests
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void AdditionalMustReruenCorrectValue()
        {
            var calculator = new Calculator();
            Assert.True(calculator.Additional(300, 20) == 320);
        }

        [Test]
        public void DivisionMustThrowException()
        {
            var claculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => claculator.Division(1, 0));
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Subtraction(70, 10) == 60);
        }

        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.False(calculator.Miltiplication(2, 6) == 10);
        }
    }
}