using System;
using mindboxLib.Models;
using Xunit;

namespace mindboxLib.Tests
{
    public class TriangleTest
    {
        [Fact]
        public void ComputeTriangleArea()
        {
            var triangle = new Triangle(5.05, 5.15, 6.001);

            var expected = 12.37220697780412;

            var actual = triangle.ComputeArea();

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(6.119473782801, 2.292395227273, 5.673877289858)]
        public void RightAngledTriangle(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            
            var expected = true;

            var actual = triangle.RightAngled();

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void RegularTriangle()
        {
            var triangle = new Triangle(2, 3, 4);
            
            var expected = false;

            var actual = triangle.RightAngled();

            Assert.Equal(expected, actual);
        }
    }
}
