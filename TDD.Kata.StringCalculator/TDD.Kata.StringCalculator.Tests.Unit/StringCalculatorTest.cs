using Xunit;

namespace TDD.Kata.StringCalculator.Tests.Unit
{
    public class StringCalculatorTest
    {
        private StringCalculator Target;

        public StringCalculatorTest()
        {
            this.Target = new StringCalculator();
        }

        [Fact]
        public void TestEmptyString()
        {
            //Arrange
            //Your set up!.
            string numbers = string.Empty;

            //Act
            //Your principal action to test.
            int result = this.Target.add(numbers);

            //Assert
            //Your expected value.
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestOneNumberString()
        {
            //Arrange
            //Your set up!.
            string numbers = "1";

            //Act
            //Your principal action to test.
            int result = this.Target.add(numbers);

            //Assert
            //Your expected value.
            Assert.Equal(1, result);
        }

        [Fact]
        public void TestTwoNumbersString()
        {
            //Arrange
            //Your set up!.
            string numbers = "1,2";

            //Act
            //Your principal action to test.
            int result = this.Target.add(numbers);

            //Assert
            //Your expected value.
            Assert.Equal(3, result);
        }

        [Fact]
        public void TestNumbersWithCommasString()
        {
            //Arrange
            //Your set up!.
            string numbers = "1\n2,3";

            //Act
            //Your principal action to test.
            int result = this.Target.add(numbers);

            //Assert
            //Your expected value.
            Assert.Equal(6, result);
        }
    }
}
