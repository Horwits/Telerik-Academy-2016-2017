using System;

namespace CohesionAndCoupling
{
    public class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine(FileUtils.GetFileExtension("example"));
            Console.WriteLine(FileUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine(
                $"Distance in the 2D space = {Utils2D.CalculateDistance2D(1, -2, 3, 4):f2}");
            Console.WriteLine(
                $"Distance in the 3D space = {Utils3D.CalculateDistance3D(5, 2, -1, 3, -6, 4):f2}");

            var width = 3;
            var height = 4;
            var depth = 5;
            Console.WriteLine($"Volume = {Utils3D.CalculateVolume(width, height, depth):f2}");
            Console.WriteLine($"Diagonal XYZ = {Utils3D.CalculateDiagonal3D(width, height, depth):f2}");
            Console.WriteLine($"Diagonal XY = {Utils2D.CalculateDiagonal2D(width, height):f2}");
            Console.WriteLine($"Diagonal XZ = {Utils2D.CalculateDiagonal2D(width, height):f2}");
            Console.WriteLine($"Diagonal YZ = {Utils2D.CalculateDiagonal2D(width, height):f2}");
        }
    }
}
