namespace MatrixMultiplicationAlgorithm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MatrixMultiplication
    {
        static void Main(string[] args)
        {
            int[,] matrixA = new int[,]
            {
                { 1, 2, 3},
                { 4, 5, 6},
                { 7, 8, 9}
            };
            int[,] matrixB = new int[,]
            {
                { 0, 1, 0},
                { 7, 3, 4},
                { 2, 6, 3}
            };

            //multiplication of matrix is when all diamentions are equal
            //multiplicate matrix A col (1, 2, 3) and matrixB row (1, 2, 3)

            int[,] matrixC = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrixC[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
