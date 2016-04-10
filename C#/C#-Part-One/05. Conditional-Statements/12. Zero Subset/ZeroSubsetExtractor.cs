using System;

class ZeroSubsetExtractor
{
    static void Main()
    {
        /*We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
        Assume that repeating the same subset several times is not a problem.*/

        Console.WriteLine("Write 5 integer numbers, splitted by interval: ");
        string input = Console.ReadLine();

        var numbersToStr = input.Split(' ');

        int[] numbers = new int[input.Length];

        bool isValid = false;
        for (int i = 0; i < numbersToStr.Length; i++)
        {
            isValid = int.TryParse(numbersToStr[i], out numbers[i]);

            if (!isValid)
            {
                break;
            }
        }

        if (isValid)
        {
            int a = numbers[0],
                b = numbers[1],
                c = numbers[2],
                d = numbers[3],
                e = numbers[4];

            bool hasZeroSubset = false;
            #region a
            #region a + digit
            if (a + b == 0)
            {
                hasZeroSubset = true;
                Console.WriteLine("{0} + {1} = 0", a, b);
            }

            if (a + c == 0)
            {
                hasZeroSubset = true;
                Console.WriteLine("{0} + {1} = 0", a, c);
            }

            if (a + d == 0)
            {
                hasZeroSubset = true;
                Console.WriteLine("{0} + {1} = 0", a, d);
            }

            if (a + e == 0)
            {
                hasZeroSubset = true;
                Console.WriteLine("{0} + {1} = 0", a, e);
            }
            #endregion

            #region a + b + digit
            if (a + b + c == 0)
            {
                hasZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
            }

            if (a + b + d == 0)
            {
                hasZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
            }

            if (a + b + e == 0)
            {
                hasZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
            }
            #endregion

            #region a + c + digit
            if (a + c + d == 0)
            {
                hasZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
            }

            if (a + c + e == 0)
            {
                hasZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} = 0", a, c, e);
            }
            #endregion

            #region a + d + digit
            if (a + d + e == 0)
            {
                hasZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} = 0", a, d, e);
            }
            #endregion

            #region a + b + c + digit
            //a+b+c+d
            if (a + b + c + d == 0)
            {
                hasZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
            }
            //a+b+c+e
            if (a + b + c + e == 0)
            {
                hasZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
            }
            #endregion

            #region a + b + d + e
            //a+b+d+e
            if (a + b + d + e == 0)
            {
                hasZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
            }
            #endregion

            #region a + c + d + e
            //a+c+d+e
            if (a + c + d + e == 0)
            {
                hasZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, c, d, e);
            }
            #endregion

            #region a + b + c + d + e
            //a+b+c+d+e
            if (a + b + c + d + e == 0)
            {
                hasZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} + {3} + {4}= 0", a, b, c, d, e);
            }
            #endregion
            #endregion

            #region b
            #region b + digit
            if (b + c == 0)
            {
                hasZeroSubset = true;
                Console.WriteLine("{0} + {1} = 0", b, c);
            }

            if (b + d == 0)
            {
                hasZeroSubset = true;
                Console.WriteLine("{0} + {1} = 0", b, d);
            }

            if (b + e == 0)
            {
                hasZeroSubset = true;
                Console.WriteLine("{0} + {1} = 0", b, e);
            }
            #endregion

            #region b + c + digit
            if (b + c + d == 0)
            {
                hasZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
            }

            if (b + c + e == 0)
            {
                hasZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
            }
            #endregion

            #region b + d + e
            if (b + d + e == 0)
            {
                hasZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
            }
            #endregion

            #region b + c + d + e
            if (b + c + d + e == 0)
            {
                hasZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", b, c, d, e);
            }
            #endregion
            #endregion

            #region c
            #region c + d
            if (c + d == 0)
            {
                hasZeroSubset = true;
                Console.WriteLine("{0} + {1} = 0", c, d);
            }
            #endregion

            #region c + e
            if (c + e == 0)
            {
                hasZeroSubset = true;
                Console.WriteLine("{0} + {1} = 0", c, e);
            }
            #endregion

            #region c + d + e
            if (c + d + e == 0)
            {
                hasZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
            }
            #endregion
            #endregion

            #region d
            #region d + e
            if (d + e == 0)
            {
                hasZeroSubset = true;
                Console.WriteLine("{0} + {1} = 0", d, e);
            }
            #endregion
            #endregion

            if (!hasZeroSubset)
            {
                Console.WriteLine("no zero subset");
            }
        }
        else
        {
            Console.WriteLine("Ivalid input!");
        }
    }
}
