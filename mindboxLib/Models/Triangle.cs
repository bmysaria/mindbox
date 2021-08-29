using System;
using mindboxLib.Models.Base;
using static mindboxLib.Extensions.MyExtensions;

namespace mindboxLib.Models
{
    public class Triangle : Figure
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public Triangle(double a, double b, double c)
        {
            if (!(a + b > c) || !(a + c > b) || !(b + c > a))
                throw new ArgumentException("This is not a triangle.");
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Negative or zero length.");
            _a = a;
            _b = b;
            _c = c;
        }

        public override double ComputeArea() => TriangleArea(_a, _b, _c);

        private static double TriangleArea(double a, double b, double c)
        {
            var semiPer = (a + b + c) / 2;
            return Math.Sqrt(semiPer * (semiPer - a) * (semiPer - b) * (semiPer - c));
        }

        public bool RightAngled() => (NearlyEqual(Math.Pow(_a, 2), Math.Pow(_b, 2) + Math.Pow(_c, 2)) ||
                                      NearlyEqual(Math.Pow(_b, 2), Math.Pow(_a, 2) + Math.Pow(_c, 2)) ||
                                      NearlyEqual(Math.Pow(_c, 2), Math.Pow(_a, 2) + Math.Pow(_b, 2)));
    }
}