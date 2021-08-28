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
                throw new NotImplementedException("This is not a circle.");
            _radius = radius;
        }

        private static double CircleArea(double radius) => (Math.PI * radius * radius);

        public override double ComputeArea() => CircleArea(_radius);
    }
}