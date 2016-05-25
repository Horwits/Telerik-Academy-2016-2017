using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
class Solution
{
    //FIX
    static BigInteger CalculateSum(List<int> numbers, int position, BigInteger count)
    {
        BigInteger sum = 0;

        for (int i = position; i <= count; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }

    static BigInteger CalculateProduct(List<int> numbers, int position, BigInteger count)
    {
        BigInteger product = 1;

        for (int i = position; i <= count; i++)
        {
            product *= numbers[i];
        }

        return product;
    }

    static void Main()
    {
        //input -> while 'till end and stuff them into list for now

        //using (var reader = new StreamReader(@"../../input.txt"))
        //{
        var cages = new List<int>();
        while (true)
        {
            var currentRowInput = Console.ReadLine();
            if (currentRowInput == "END")
            {
                break;
            }

            var currentNum = int.Parse(currentRowInput);
            cages.Add(currentNum);
        }

        int cycles = 1;

        var concatenated = new StringBuilder();
        while (true)
        {
            if (cycles < cages.Count)
            {
                BigInteger beforeSum = cages
                                        .Take(cycles)
                                        .Sum();

                if (cycles + beforeSum < cages.Count)
                {
                    BigInteger afterSum = CalculateSum(cages, cycles, beforeSum);
                    BigInteger afterProduct = CalculateProduct(cages, cycles, beforeSum);

                    int appendStartIndex = (int)(cycles + beforeSum);
                    int appendLength = cages.Count - appendStartIndex;
                    concatenated
                        .Append(afterSum)
                        .Append(afterProduct)
                        .Append(string.Join("", cages.GetRange(appendStartIndex, appendLength)));

                    cages.Clear();

                    var newCagesBuilder = new StringBuilder();
                    foreach (var symbol in concatenated.ToString())
                    {
                        if (symbol != '0' && symbol != '1')
                        {
                            newCagesBuilder.Append(symbol);
                        }
                    }

                    concatenated.Clear();

                    cages = newCagesBuilder
                                .ToString()
                                .Select(x => x - '0')
                                .ToList();
                }
                else
                {
                    break;
                }
            }
            else
            {
                break;
            }

            cycles++;
        }

        Console.WriteLine(string.Join(" ", cages));
    }
    //}
}
