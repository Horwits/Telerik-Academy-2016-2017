namespace MaxPlatformIn2DArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using MatrixBiggestElement;

    public class TwoDiamantionalArray
    {
        /*The static methods are used only becouse it's easier and for the training.
        The use of static fields, properties, methods, have to be reduced to minimal.*/ 
        public static int[,] InnerMatrix { get; set; }

        public static void FillMatrix(int rows, int colls)
        {
            InnerMatrix = new int[rows, colls];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colls; j++)
                {
                    InnerMatrix[i, j] = MaxElement.CreateRandomValue();
                }
            }
        }

        public static int FindMax2x2PlatformSum(out int maxRow, out int maxColl)
        {
            var max = int.MinValue;

            var rows = InnerMatrix.GetLength(0);
            var colls = InnerMatrix.GetLength(1);

            int leftCornerRows = 0;
            int leftCornerColls = 0;
            for (int r = 0; r < rows - 1; r++)
            {
                for (int c = 0; c < colls - 1; c++)
                {
                    var currentValue =
                        InnerMatrix[r, c] +
                        InnerMatrix[r, c + 1] +
                        InnerMatrix[r + 1, c] +
                        InnerMatrix[r + 1, c + 1];

                    if (currentValue > max)
                    {
                        max = currentValue;

                        leftCornerRows = r;
                        leftCornerColls = c;
                    }
                }
            }

            maxRow = leftCornerRows;
            maxColl = leftCornerColls;

            return max;
        }

        public static void PrintMatrix()
        {
            int rows = InnerMatrix.GetLength(0);
            int colls = InnerMatrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colls; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(InnerMatrix[i, j]);
                    }
                    else
                    {
                        Console.Write(" " + InnerMatrix[i, j]);
                    }
                }

                Console.WriteLine();
            }
        }
    }

    public class Execute
    {
        static void Main()
        {
            TwoDiamantionalArray.FillMatrix(5, 5);
            TwoDiamantionalArray.PrintMatrix();

            int maxRow = 0;
            int maxCol = 0;
            var max2dPlatformSum = TwoDiamantionalArray.FindMax2x2PlatformSum(out maxRow, out maxCol);

            Console.WriteLine("leftCOrner = [{0}, {1}]", maxRow, maxCol);
            Console.WriteLine("max = " + max2dPlatformSum);
        }
    }
}
