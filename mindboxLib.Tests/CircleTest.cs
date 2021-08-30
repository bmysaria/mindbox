using System;
using mindboxLib.Models;
using Xunit;

namespace mindboxLib.Tests
{
    public class CircleTest
    {
        [Fact]
        public void ComputeCircleArea()
        {
            var circle = new Circle(36.432343);

            var expected = 4169.884989696057;

            var actual = circle.ComputeArea();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-10)]
        [InlineData(double.MinValue)]
        [InlineData(0)]
        public void NegativeZeroMinValue(double r)
        {
            var ex = Assert.Throws<ArgumentException>(() => new Circle(r));
            
            Assert.Equal("Negative or zero radius.", ex.Message);
        }

        [Fact]
        public void MaxValue()
        {
            var circle = new Circle(double.MaxValue);
            
            var ex = Assert.Throws<OverflowException>(() => circle.ComputeArea());
            
            Assert.Equal("An overflow occured.", ex.Message);
        }
    }
}