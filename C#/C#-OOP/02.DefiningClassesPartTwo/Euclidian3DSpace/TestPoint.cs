namespace Euclidian3DSpace
{
    using System;

    using Models;

    public static class TestPoint
    {
        public static void Main(string[] args)
        {
            var point = new Point3D()
            {
                X = -7,
                Y = -4,
                Z = 3
            };

            var point2 = new Point3D()
            {
                X = 17,
                Y = 6,
                Z = 2.5
            };

            var distance = Point3dExtensions.CalculateDistance(point, point2);
            Console.WriteLine(distance);

            Console.WriteLine(point.ToString());

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine(Point3D.Origin);

            Console.WriteLine();

            var path = PathStorage.LoadPathFromTextFile(@"../../paths.txt");

            foreach (var item in path.SequenceOfPoints)
            {
                Console.WriteLine(item);
            }

            var saveFilePath = @"../../saved.txt";
            PathStorage.SavePathFromTextFile(path, saveFilePath);
        }
    }
}
