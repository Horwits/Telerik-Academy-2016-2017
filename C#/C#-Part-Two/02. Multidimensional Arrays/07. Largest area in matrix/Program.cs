﻿using System;

class LargestArea
{
    static bool[,] visited = new bool[1000, 1000];
    static int[] dx = { -1, 1, 0, 0 };
    static int[] dy = { 0, 0, -1, 1 };
    static int newX;
    static int newY;

    static int dfs(int[,] matrix, int x, int y, int value)
    {
        if (visited[x, y])
        {
            return 0;
        }
        else
        {
            visited[x, y] = true;
            int best = 0;
            int bestX = x, bestY = y;
            for (int i = 0; i < 4; i++)
            {

                int modx = dx[i] + x;
                int mody = dy[i] + y;

                //if we are outside of our matrix
                if (modx == -1 || modx >= matrix.GetLength(0) ||
                    mody == -1 || mody >= matrix.GetLength(1))
                {
                    continue;
                }

                //if neighbour value is the same, "DFS" it
                if (matrix[modx, mody] == value)
                {
                    int v = dfs(matrix, modx, mody, value);
                    best += v;
                }
                newX = bestX;
                newY = bestY;
            }

            return best + 1;
        }
    }

    static int[,] GetMatrixFromInput(int n, int m)
    {
        int[,] matrix = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            var currentInputRow = Console.ReadLine().Split(' ');
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(currentInputRow[j]);
            }
        }

        return matrix;
    }

    static void Main()
    {
        string heightAndWidth = Console.ReadLine();
        var splitted = heightAndWidth.Split(' ');
        int n = int.Parse(splitted[0]);
        int m = int.Parse(splitted[1]);

        var matrix = GetMatrixFromInput(n, m);

        //int res = dfs(matrix, 0, 1, 3);
        //Console.WriteLine(res);

        //traverse the matrix in search for largest area
        int current = 0;
        int max = 0;
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                if (visited[rows, cols] == false)
                {
                    current = dfs(matrix, rows, cols, matrix[rows, cols]);
                    if (current > max)
                    {
                        max = current;
                    }
                }
            }
        }
        Console.WriteLine(max);
    }
}