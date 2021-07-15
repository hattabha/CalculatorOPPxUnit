using System;
using Xunit;
using CalculatorOPP;

namespace TestProject1
{
    public class CalculatorOPPxTest
    {
        //Program.Calculator calculator = new Program.Calculator();

        [Fact]
        public void AddTest1()
        {

            Program.Calculator calculator = new Program.Calculator();
            double expected = 5;
            double actual = calculator.Add(2, 3);
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void AddTest2()
        {
            Program.Calculator calculator = new Program.Calculator();
            double expected = 5;
            double actual = calculator.Add(2, 3);
            Assert.Equal(expected, actual);

        }

        [Fact]

        public void SubTest1()
        {
            Program.Calculator calculator = new Program.Calculator();
              double expected = 5;
              double actual = calculator.Sub(10, 5);
              Assert.Equal(expected, actual);

        }

        [Fact]
        public void SubstarctTest2()
        {
            Program.Calculator calculator = new Program.Calculator();
            double expected = 5;
            double actual = calculator.Sub(2, 3);
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void MultiplicationTest1()
        {
            Program.Calculator calculator = new Program.Calculator();
            double expected = 6;
            double actual = calculator.Mult(2, 3);
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void DivitionTest1()
        {
            Program.Calculator calculator = new Program.Calculator();
            double expected = 2;
            double actual = calculator.Div(10, 0);
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void ProcentTest1()
        {
            Program.Calculator calculator = new Program.Calculator();
            double expected = 5;
            double actual = calculator.Procent(2, 3);
            Assert.Equal(expected, actual);

        }

        
    }
}
