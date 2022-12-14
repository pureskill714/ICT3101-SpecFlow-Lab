using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT3101_Calculator.UnitTests
{
    public class MagicNumbersTests
    {
        private Calculator _calculator;
        private FileReader _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new FileReader();
            _calculator = new Calculator();
        }


        [Test]
        public void TestingPositiveMagicNumbers()
        {
            // Act
            double result = _calculator.GenMagicNum(0, _mockFileReader);
            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void TestingNegativeMagicNumbers()
        {
            // Act
            double result = _calculator.GenMagicNum(3, _mockFileReader);
            // Assert
            Assert.That(result, Is.EqualTo(8));
        }
    }
}
