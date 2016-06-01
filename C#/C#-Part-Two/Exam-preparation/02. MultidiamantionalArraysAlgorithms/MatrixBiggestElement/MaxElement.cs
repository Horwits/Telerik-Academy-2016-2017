namespace MatrixBiggestElement
{
    using System;

    public static class MaxElement
    {
        private static int[,] innerMatrix = new int[2, 10];
        private static Random randomValue = new Random();

        public static int CreateRandomValue()
        {
            var random = 0;

            for (int i = 0; i < 5; i++)
            {
                random = randomValue.Next(1, 100);
            }

            return random;
        }

        public static void FillMatrix()
        {
            int rows = innerMatrix.GetLength(0);
            int colls = innerMatrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colls; j++)
                {
                    innerMatrix[i, j] = CreateRandomValue();
                }
            }
        }

        public static int FindMax()
        {
            var max = int.MinValue;

            int rows = innerMatrix.GetLength(0);
            int colls = innerMatrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colls; j++)
                {
                    var currentNum = innerMatrix[i, j];
                    if (currentNum > max)
                    {
                        max = currentNum;
                    }
                }
            }

            return max;
        }

        public static void PrintMatrixToConsole()
        {
            int rows = innerMatrix.GetLength(0);
            int colls = innerMatrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colls; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(innerMatrix[i, j]);
                    }
                    else
                    {
                        Console.Write(" " + innerMatrix[i, j]);
                    }
                }

                Console.WriteLine();
            }
        }
    }

    public class Execute
    {
        static void Main(string[] args)
        {
            MaxElement.FillMatrix();
            MaxElement.PrintMatrixToConsole();
            var max = MaxElement.FindMax();
            Console.WriteLine("max - " + max);
        }

    }
}
