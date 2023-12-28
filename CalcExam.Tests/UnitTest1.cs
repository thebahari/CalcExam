using System;
using Xunit;

namespace CalcExam.Tests
{
    public class CalcServiceTests
    {
        [Trait("Math Ops","Simple")]
        [Theory(DisplayName = "Add Number")]
        [InlineData(4,5,9)]
        [InlineData(2,3,5)]
        public void TestAddNumbers(int x,int y,int expectedResult)
        {
            //Arrange
            var cs=new CalcService();
            //Act
            var result = cs.AddNumber(x, y);
            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Trait("Math Ops", "Simple")]
        [Theory]
        [InlineData(4,5, -1)]
        [InlineData(12, 3, 9)]
        public void TestSubtractNumber(int x, int y, int expectedResult)
        {
            //Arrange
            var cs = new CalcService();
            //Act
            var result = cs.SubtractNumber(x, y);
            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Trait("Math Ops", "Harder")]
        [Theory]
        [InlineData(2,2,4)]
        [InlineData(12,2,24)]
        public void MultiplyNumbers(int x, int y, int expectedResult)
        {
            //Arrange
            var cs = new CalcService();
            //Act
            var result = cs.MultiplyNumbers(x, y);
            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Trait("Math Ops", "Misc")]
        [Theory]
        [InlineData(1, false)]
        [InlineData(2, true)]
        public void TestEvenNumberWithBoolCompare(int x, bool expectedResult)
        {
            var cs = new CalcService();
            var actualResult = cs.IsEven(x);
            Assert.Equal(expectedResult, actualResult);
        }

        [Trait("Math Ops", "Misc")]
        [Theory]
        [InlineData(2)]
        public void TestEvenNumberForTrueResult(int x)
        {
            var cs = new CalcService();
            var actualResult = cs.IsEven(x);
            Assert.True(actualResult);
        }

        [Theory]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(22, true)]
        [InlineData(32, true)]
        public void TestEvenOrOdd(int x, bool isEven)
        {
            var cs = new CalcService();
            var actualResult = cs.IsEvenOrOdd(x);
            Assert.Equal(isEven, actualResult);
        }

        [Trait("Math Ops", "Harder")]
        [Theory]
        [InlineData(1, 0)]
        public void TestDivideByZero(int x, int y)
        {
            var cs = new CalcService();
            //var actualResult = cs.UnsafeDivide(x, y);

            Exception ex = Assert
                .Throws<DivideByZeroException>(() => cs.UnsafeDivide(x, y));

        }

        [Fact]
        public void ExamTest()
        {
            Assert.Equal(2,2);
           
        }
    }
}
