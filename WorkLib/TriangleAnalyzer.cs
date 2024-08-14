namespace WorkLib;

public static class TriangleAnalyzer
{
    public static TriangleType DetermineTriangleType(double a, double b, double c)
    {
        var a2 = a * a;
        var b2 = b * b;
        var c2 = c * c;

        double max = a2, sumOfOthers = b2 + c2;

        if (b2 > max)
        {
            max = b2;
            sumOfOthers = a2 + c2;
        }
        if (c2 > max)
        {
            max = c2;
            sumOfOthers = a2 + b2;
        }

        return GetTriangleType(sumOfOthers, max);
    }

    private static TriangleType GetTriangleType(double sumOfOthers, double max)
    {
        const double tolerance = 1e-10;

        if (sumOfOthers > max)
            return TriangleType.Sharp;
        if (Math.Abs(sumOfOthers - max) < tolerance)
            return TriangleType.Rectangular;
        return TriangleType.Obtuse;
    }
}
