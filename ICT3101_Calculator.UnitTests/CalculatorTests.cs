namespace ICT3101_Caculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }

        //[Test]
        //public void Divide_WithZerosAsInputs_ResultThrowArgumentException()
        //{
            //Assert.That(() => _calculator.Divide(0, 0), Throws.ArgumentException);
        //}

        [Test]
        [TestCase(10, 0)]
        [TestCase(0, 10)]
        //[TestCase(0, 0)]
        public void Divide_WithZerosAsInputs_ResultThrowArgumentException(int a, int b)
        {
            Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
        }

        [TestCase(-1)]
        [TestCase(-100)]
        public void Factorial_WithNegativeAsInput_ResultThrowArgumentException(int num)
        {
            Assert.Throws<ArgumentException>(() => _calculator.Factorial(num));
        }

        [TestCase(-1, 100)]
        [TestCase(100, -1)]
        public void AreaOfTriangle_WithNegativeAsInput_ResultThrowArgumentException(int length, int height)
        {

            Assert.Throws<ArgumentException>(() => _calculator.CalculateTriangleArea(length, height));
        }

        [TestCase(-1)]
        [TestCase(-100)]
        public void AreaOfCircle_WithNegativeRadiusAsInput_ResultThrowArgumentException(int radius)
        {

            Assert.Throws<ArgumentException>(() => _calculator.CalculateCircleArea(radius));
        }


    }
}
