namespace CohesionAndCoupling
{
    using System;

    public class Utils2D
    {
        public static double CalculateDistance2D(double x1, double y1, double x2, double y2)
        {
            var distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        public static double CalculateDiagonal2D(double width, double height)
        {
            var distance = CalculateDistance2D(0, 0, width, height);
            return distance;
        }
    }
}