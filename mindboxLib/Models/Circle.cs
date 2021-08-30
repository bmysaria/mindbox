using System;
using mindboxLib.Models.Base;

namespace mindboxLib.Models
{
    public class Circle : Figure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Negative or zero radius.");
            _radius = radius;
        }

        private static double CircleArea(double radius)
        {
            var res = Math.PI * radius * radius;
            if (double.IsPositiveInfinity(res))
                throw new OverflowException("An overflow occured.");
            return res;
        }

        public override double ComputeArea() => CircleArea(_radius);
    }
}