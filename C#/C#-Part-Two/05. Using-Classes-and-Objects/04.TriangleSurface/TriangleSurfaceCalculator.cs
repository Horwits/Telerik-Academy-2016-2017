using System;

class TriangleSurfaceCalculator
{
    public static double CalculateTriangleSurface(double side, double altitude)
    {
        double surface = (side * altitude) / 2;
        return surface;
    }

    public static double CalculateTriangleSurface(double a, double b, double c)
    {
        double perimeter = (a + b + c) / 2;

        double lengths = perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c);

        double surface = Math.Sqrt(lengths);
        return surface;
    }

    public static double CalculateTriangleSurfaceByTwoSidesAndAngle(double a, double b, double c)
    {
        double radians = (c * Math.PI) / 180;
        double surface = (a * b * Math.Sin(radians)) * 0.5;
        return surface;
    }

    static void Main()
    {
        double a = 23.2,
            h = 5;

        double surface = CalculateTriangleSurface(a, h);
        Console.WriteLine(surface);

        double b = 12,
            c = 13;

        a = 11;

        surface = CalculateTriangleSurface(a, b, c);
        Console.WriteLine("{0:f2}", surface);

        a = 10;
        b = 7;
        c = 25;

        surface = CalculateTriangleSurfaceByTwoSidesAndAngle(a, b, c);
        Console.WriteLine("{0:f2}", surface);
    }
}
