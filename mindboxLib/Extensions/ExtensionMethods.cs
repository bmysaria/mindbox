using System;

namespace mindboxLib.Extensions
{
    public static class MyExtensions
    {
        public static bool NearlyEqual(double a, double b) =>
            a - Double.Epsilon < b && b < a + Double.Epsilon;
    }
}