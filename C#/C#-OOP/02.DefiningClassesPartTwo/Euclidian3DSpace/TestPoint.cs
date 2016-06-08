namespace Euclidian3DSpace
{
    using System;

    public static class TestPoint
    {
        public static void Main(string[] args)
        {
            var point = new Point3D()
            {
                X = 3,
                Y = 4,
                Z = 5
            };

            Console.WriteLine(point.ToString());

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine(Point3D.StartOfTheCoordinateSystem);
        }
    }
}
