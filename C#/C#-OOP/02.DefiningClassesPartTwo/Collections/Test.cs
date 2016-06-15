namespace Collections
{
    using Collections.Models;

    internal class Test
    {
        internal static void Main(string[] args)
        {
            var matrix = new Matrix<int>(5, 5);

            matrix[0, 6] = 5;

            System.Console.WriteLine(matrix[0, 1]);
        }
    }
}
