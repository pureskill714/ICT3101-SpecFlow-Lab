using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICT3101_Calculator.UnitTests
{
    class AdditionalCalculatorTest
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
            fr.Read("\\Users\\rahee\\Desktop\\3101 Specflow lab\\magicNumbers.txt")).Returns(new string[4] {"1", "2", "3", "4"});
            _calculator = new Calculator();
        }

        [Test]
        public void TestingPositiveMagicNumbers()
        {
            // Act
            double result = _calculator.GenMagicNum(0, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

    }

}

        