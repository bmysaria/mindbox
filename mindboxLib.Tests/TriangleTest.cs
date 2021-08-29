using System;
using mindboxLib.Models;
using Xunit;

namespace mindboxLib.Tests
{
    public class TriangleTest
    {
        //[Fact]
        // public void InvalidTriangle1()
        // {
        //     var triangle1 = new Triangle(50, 10, 10);
        // }
        //
        // [Fact]
        // public void InvalidTriangle2()
        // {
        //     var triangle2 = new Triangle(-5, 5, 5);
       // }
        [Fact]
        public void ComputeTriangleArea1()
        {
            var triangle = new Triangle(5.05, 5.15, 6.001);

            var expected = 12.37220697780412;

            var actual = triangle.ComputeArea();

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void RightAngledTriangle()
        {
            var triangle = new Triangle(3, 4, 5.000000000000001);

            var expected = true;

            var actual = triangle.RightAngled();

            Console.WriteLine(actual);

            Assert.Equal(expected, actual);
        }
    }
}
