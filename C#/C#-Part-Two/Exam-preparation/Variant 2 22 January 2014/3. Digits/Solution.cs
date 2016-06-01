using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Solution
{
    //TODO FIX -> CHANGE THE OUTPUT BY REMOVING THE ELSE PART FROM FINDPATTERN
    static int[][] matrix;
    static long sum = 0;
    static bool isZero;
    static bool isOne;
    static bool isTwo;
    static bool isThree;
    static bool isFour;
    static bool isFive;
    static bool isSix;
    static bool isSeven;
    static bool isEight;
    static bool isNine;

    static void ReadInput()
    {
        var n = int.Parse(Console.ReadLine());

        matrix = new int[n][];
        for (int i = 0; i < n; i++)
        {
            matrix[i] = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }

    //my mistake was the reset of the bool values after adding them into the sum
    static void FindPattern()
    {
        isOne = false;
        var n = matrix[0].Length;
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                var currentPatternToSearch = matrix[row][col];
                if (currentPatternToSearch == 0)
                {
                    if (col + 2 < n && row + 4 < n)
                    {
                        isZero = matrix[row][col] == 0 &&
                            matrix[row][col + 1] == 0 &&
                            matrix[row][col + 2] == 0 &&
                            matrix[row + 1][col] == 0 &&
                            matrix[row + 1][col + 2] == 0 &&
                            matrix[row + 2][col] == 0 &&
                            matrix[row + 2][col + 2] == 0 &&
                            matrix[row + 3][col] == 0 &&
                            matrix[row + 3][col + 2] == 0 &&
                            matrix[row + 4][col] == 0 &&
                            matrix[row + 4][col + 1] == 0 &&
                            matrix[row + 4][col + 2] == 0;

                        if (isZero)
                        {
                            sum += 0;
                            isZero = false;
                        }
                    }
                    else
                    {
                        isZero = false;
                    }
                }
                else if (currentPatternToSearch == 1)
                {
                    #region 1
                    if (col - 2 >= 0 && row + 4 < n)
                    {
                        isOne = matrix[row][col] == 1 &&
                            matrix[row + 1][col] == 1 &&
                            matrix[row + 1][col - 1] == 1 &&
                            matrix[row + 2][col] == 1 &&
                            matrix[row + 3][col] == 1 &&
                            matrix[row + 4][col] == 1;

                        if (isOne)
                        {
                            sum += 1;
                            isOne = false;
                        }
                    }
                    else
                    {
                        sum += 0;
                        isOne = false;
                    }
                    #endregion
                }
                else if (currentPatternToSearch == 2)
                {
                    #region 2
                    if (col - 1 >= 0 && col + 1 < n && row + 4 < n)
                    {
                        isTwo = matrix[row][col] == 2 &&
                            matrix[row + 1][col + 1] == 2 &&
                            matrix[row + 1][col - 1] == 2 &&
                            matrix[row + 2][col + 1] == 2 &&
                            matrix[row + 3][col] == 2 &&
                            matrix[row + 4][col] == 2 &&
                            matrix[row + 4][col + 1] == 2 &&
                            matrix[row + 4][col - 1] == 2;

                        if (isTwo)
                        {
                            sum += 2;
                            isTwo = false;
                        }
                    }
                    else
                    {
                        isTwo = false;
                    }
                    #endregion
                }
                else if (currentPatternToSearch == 3)
                {
                    #region 3
                    if (col + 2 < n && row + 4 < n)
                    {
                        isThree = matrix[row][col] == 3 &&
                            matrix[row][col + 1] == 3 &&
                            matrix[row][col + 2] == 3 &&
                            matrix[row + 1][col + 2] == 3 &&
                            matrix[row + 2][col + 1] == 3 &&
                            matrix[row + 2][col + 2] == 3 &&
                            matrix[row + 3][col + 2] == 3 &&
                            matrix[row + 4][col] == 3 &&
                            matrix[row + 4][col + 1] == 3 &&
                            matrix[row + 4][col + 2] == 3;

                        if (isThree)
                        {
                            sum += 3;
                            isThree = false;
                        }
                    }
                    else
                    {
                        isThree = false;
                    }
                    #endregion
                }
                else if (currentPatternToSearch == 4)
                {
                    #region 4
                    if (col + 2 < n && row + 4 < n)
                    {
                        isFour = matrix[row][col] == 4 &&
                                matrix[row + 1][col] == 4 &&
                                matrix[row + 2][col] == 4 &&
                                matrix[row][col + 2] == 4 &&
                                matrix[row + 1][col + 2] == 4 &&
                                matrix[row + 2][col + 2] == 4 &&
                                matrix[row + 2][col + 1] == 4 &&
                                 matrix[row + 3][col + 2] == 4 &&
                                matrix[row + 4][col + 2] == 4;

                        if (isFour)
                        {
                            sum += 4;
                            isFour = false;
                        }
                    }
                    else
                    {
                        isFour = false;
                    }
                    #endregion
                }
                else if (currentPatternToSearch == 5)
                {
                    #region 5
                    if (col + 2 < n && row + 4 < n)
                    {
                        isFive = matrix[row][col] == 5 &&
                            matrix[row][col + 1] == 5 &&
                            matrix[row][col + 2] == 5 &&
                            matrix[row + 1][col] == 5 &&
                            matrix[row + 2][col] == 5 &&
                            matrix[row + 2][col + 1] == 5 &&
                            matrix[row + 2][col + 2] == 5 &&
                            matrix[row + 3][col + 2] == 5 &&
                            matrix[row + 4][col] == 5 &&
                            matrix[row + 4][col + 1] == 5 &&
                            matrix[row + 4][col + 2] == 5;

                        if (isFive)
                        {
                            sum += 5;
                            isFive = false;
                        }
                    }
                    else
                    {
                        isFive = false;
                    }
                    #endregion
                }
                else if (currentPatternToSearch == 6)
                {
                    #region 6
                    if (col + 2 < n && row + 4 < n)
                    {
                        isSix = matrix[row][col] == 6 &&
                            matrix[row][col + 1] == 6 &&
                            matrix[row][col + 2] == 6 &&
                            matrix[row + 1][col] == 6 &&
                            matrix[row + 2][col] == 6 &&
                            matrix[row + 2][col + 1] == 6 &&
                            matrix[row + 2][col + 2] == 6 &&
                            matrix[row + 3][col] == 6 &&
                            matrix[row + 3][col + 2] == 6 &&
                            matrix[row + 4][col] == 6 &&
                            matrix[row + 4][col + 1] == 6 &&
                            matrix[row + 4][col + 2] == 6;

                        if (isSix)
                        {
                            sum += 6;
                            isSix = false;
                        }
                    }
                    else
                    {
                        isSix = false;
                    }
                    #endregion
                }
                else if (currentPatternToSearch == 7)
                {
                    #region 7
                    if (col + 2 < n && row + 4 < n)
                    {
                        isSeven = matrix[row][col] == 7 &&
                            matrix[row][col + 1] == 7 &&
                            matrix[row][col + 2] == 7 &&
                            matrix[row + 1][col + 2] == 7 &&
                            matrix[row + 2][col + 1] == 7 &&
                            matrix[row + 3][col + 1] == 7 &&
                            matrix[row + 4][col + 1] == 7;

                        if (isSeven)
                        {
                            sum += 7;
                            isSeven = false;
                        }
                    }
                    else
                    {
                        isSeven = false;
                    }
                    #endregion
                }
                else if (currentPatternToSearch == 8)
                {
                    if (col + 2 < n && row + 4 < n)
                    {
                        isEight = matrix[row][col] == 8 &&
                            matrix[row][col + 1] == 8 &&
                            matrix[row][col + 2] == 8 &&
                            matrix[row + 1][col] == 8 &&
                            matrix[row + 1][col + 2] == 8 &&
                            matrix[row + 2][col + 1] == 8 &&
                            matrix[row + 3][col] == 8 &&
                            matrix[row + 3][col + 2] == 8 &&
                            matrix[row + 4][col] == 8 &&
                            matrix[row + 4][col + 1] == 8 &&
                            matrix[row + 4][col + 2] == 8;

                        if (isEight)
                        {
                            sum += 8;
                            isEight = false;
                        }
                    }
                    else
                    {
                        isEight = false;
                    }
                }
                else if (currentPatternToSearch == 9)
                {
                    if (col + 2 < n && row + 4 < n)
                    {
                        isNine = matrix[row][col] == 9 &&
                            matrix[row][col + 1] == 9 &&
                            matrix[row][col + 2] == 9 &&
                            matrix[row + 1][col] == 9 &&
                            matrix[row + 1][col + 2] == 9 &&
                            matrix[row + 2][col + 1] == 9 &&
                            matrix[row + 2][col + 2] == 9 &&
                            matrix[row + 3][col + 2] == 9 &&
                            matrix[row + 4][col] == 9 &&
                            matrix[row + 4][col + 1] == 9 &&
                            matrix[row + 4][col + 2] == 9;

                        if (isNine)
                        {
                            sum += 9;
                            isNine = false;
                        }
                    }
                    else
                    {
                        isNine = false;
                    }
                }
            }
        }
    }

    static void Main()
    {
        //1. Read input
        ReadInput();
        //2. Create bool pattern for all numbers
        //2.1 every digit has a border case 1 has to be on min 3rth col and from that has to have +4 row
        //2.2. 0,2,3,4,5,6,7,8,9 need 3 on the left and four down
        //2.3
        FindPattern();
        //3. Find the sum
        //when certain pattern is found add the respective digit to a static int sum
        //4.Output
        Console.WriteLine(sum);
        //The output data consists of a single line. It should contain the sum of all the digit patterns in the matrix
    }
}
