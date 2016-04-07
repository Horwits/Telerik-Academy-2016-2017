using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        string currentNumberToString = Console.ReadLine();
        int length = currentNumberToString.Length;

        BigInteger product = 1;
        int transformations = 0;

        while (true)
        {
            while (length > 1)
            {
                long currentSum = 0;
                length--;

                for (int position = 0; position < length; position++)
                {
                    if (position % 2 == 0)
                    {
                        currentSum += (currentNumberToString[position] - '0');
                    }
                }

                if (currentSum > 0)
                {
                    product *= currentSum;
                }
            }

            transformations++;

            if (transformations == 10)
            {
                Console.WriteLine(product);
                break;
            }

            if (product > 9 && transformations != 10)
            {
                currentNumberToString = product.ToString();
                length = currentNumberToString.Length;
                product = 1;
                continue;
            }
            else if (product < 10)
            {
                Console.WriteLine(transformations);
                Console.WriteLine(product);
                break;
            }
        }
    }
}
