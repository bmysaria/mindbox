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
    }
}