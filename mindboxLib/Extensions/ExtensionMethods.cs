using System;

namespace mindboxLib.Extensions
{
    public static class MyExtensions
    {
        public static bool NearlyEqual(double a, double b)
        {
            if (a == b)
                return true;
            if (a - Double.Epsilon < b && b < a + Double.Epsilon)
                return true;
            return false;
        }
    }
}