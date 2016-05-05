using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
    private static void FillMatrix(int[,] matrix, int r, int c)
    {
        int counter = 0;
        for (int i = r - 1; i >= 0; i--)
        {
            int row = i;
            int col = 0;
            do
            {
                matrix[row, col] = counter;
                col++;
                row++;
            } while (row < r && col < c);

            counter += 3;
        }
        for (int i = 1; i < c; i++)
        {
            int col = i;
            int row = 0;
            do
            {
                matrix[row, col] = counter;
                col++;
                row++;
            } while (col < c);
            counter += 3;
        }
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j]);
            }

            Console.WriteLine();
        }
    }

    static void Main()
    {
        var dimansionsOfFiled = Console.ReadLine().Split(' ');
        var rows = int.Parse(dimansionsOfFiled[0]);
        var colls = int.Parse(dimansionsOfFiled[1]);

        var matrix = new int[rows, colls];
        FillMatrix(matrix, rows, colls);

        var directionsToMoveNumber = int.Parse(Console.ReadLine());

        int sum = 0;

        var currentRow = rows - 1;
        var currentCol = 0;
        for (int i = 0; i < directionsToMoveNumber; i++)
        {
            var currentMove = Console.ReadLine().Split(' ');
            var times = int.Parse(currentMove[1]);

            int counter = 0;
            while (counter < times)
            {
                bool isOutside = false;

                var direction = currentMove[0];
                switch (direction)
                {
                    case "RU":
                    case "UR":
                        if (counter != 0)
                        {
                            currentRow -= 1;
                            currentCol += 1;

                            if (currentCol >= colls)
                            {
                                counter++;
                                currentCol--;
                                currentRow++;
                                isOutside = true;
                                break;
                            }

                            if (currentRow < 0)
                            {
                                counter++;
                                currentCol--;
                                currentRow++;
                                isOutside = true;
                                break;
                            }
                        }

                        break;

                    case "LU":
                    case "UL":
                        if (counter != 0)
                        {
                            currentRow -= 1;
                            currentCol -= 1;

                            if (currentCol < 0)
                            {
                                counter++;
                                currentCol++;
                                currentRow++;
                                isOutside = true;
                                break;
                            }

                            if (currentRow < 0)
                            {
                                counter++;
                                currentCol++;
                                currentRow++;
                                isOutside = true;
                                break;
                            }
                        }

                        break;

                    case "RD":
                    case "DR":
                        if (counter != 0)
                        {
                            currentRow += 1;
                            currentCol += 1;

                            if (currentCol >= colls)
                            {
                                counter++;
                                currentCol--;
                                currentRow--;
                                isOutside = true;
                                break;
                            }

                            if (currentRow >= rows)
                            {
                                counter++;
                                currentCol--;
                                currentRow--;
                                isOutside = true;
                                break;
                            }
                        }

                        break;

                    case "LD":
                    case "DL":
                        if (counter != 0)
                        {
                            currentRow += 1;
                            currentCol -= 1;

                            if (currentCol < 0)
                            {
                                counter++;
                                currentCol++;
                                currentRow--;
                                isOutside = true;
                                break;
                            }

                            if (currentRow >= rows)
                            {
                                counter++;
                                currentCol++;
                                currentRow--;
                                isOutside = true;
                                break;
                            }
                        }

                        break;
                }

                if (!isOutside)
                {
                    sum += matrix[currentRow, currentCol];
                    matrix[currentRow, currentCol] = 0;
                }

                counter++;
            }
        }

        Console.WriteLine(sum);
    }
}
