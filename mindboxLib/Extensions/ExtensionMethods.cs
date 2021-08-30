using System;

namespace mindboxLib.Extensions
{
    public static class MyExtensions
    {
        public static readonly double TargetPrecision = Math.Pow(2.0, -42);
        
        public static bool NearlyEqual(double x, double y) =>
            (2.0 * Math.Abs(x - y) <= TargetPrecision * (Math.Abs(x) + Math.Abs(y)));
    }
}