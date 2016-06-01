using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Program
{
    static int SumOfFirstICages(List<string> numbers, int i)
    {
        var index = 0;
        var sum = 0;
        do
        {
            sum += int.Parse(numbers[index]);
            index++;
        } while (index <= i);

        return sum;
    }

    static long SumOfNextSCages(List<string> numbers, long s, int index)
    {
        var sum = 0L;
        s += index;
        for (int i = index; i < s; i++)
        {
            sum += long.Parse(numbers[i]);
        }

        return sum;
    }

    //change it to be biginteger
    static BigInteger ProductOfNextSCages(List<string> numbers, long s, int index)
    {
        var product = 1;
        s += index;
        do
        {
            product *= int.Parse(numbers[index]);
            index++;
        } while (index < s);

        return product;
    }

    static string AppendLastedCages(List<string> numbers, long s, int index)
    {
        var appended = new StringBuilder();
        for (long i = (index + 1) + s; i < numbers.Count; i++)
        {
            appended.Append(numbers[(int)i]);
        }

        return appended.ToString();
    }

    static void Main(string[] args)
    {

        //1. read input -> append them in a sbuilder and then proceed
        var cages = new List<string>();
        while (true)
        {
            var currentLine = Console.ReadLine();
            if (currentLine == "END")
            {
                break;
            }

            cages.Add(currentLine);
        }

        var i = 0;
        while (true)
        {
            var n = cages.Count;
            //1.	If there are less than i cages, the factory stops the multiplication process.
            if (i > n)
            {
                break;
            }

            //2.	The factory gets the first i cages and calculate the sum s of all bunnies in them. 
            var sumOfFirstICages = SumOfFirstICages(cages, i);

            //3.	If there are less than s cages after the i-th one, the factory stops the multiplication process.
            if (i + sumOfFirstICages >= n)
            {
                break;
            }

            //4.	The factory gets the next s cages after the i-th one and calculates the sum and product of all bunnies in them. 
            var sumOfNextSCages = SumOfNextSCages(cages, sumOfFirstICages, i + 1);
            var productOfNextSCages = ProductOfNextSCages(cages, sumOfFirstICages, i + 1);

            //5.	These sum and product are concatenated as next cages. All cages that were not included in the calculations are simply appended to next.
            var nextCages = new StringBuilder();
            nextCages
                .Append(sumOfNextSCages)
                .Append(productOfNextSCages)
                .Append(AppendLastedCages(cages, sumOfFirstICages, i));

            cages.Clear();
            //6.	The factory gets several empty cages then gets the digits of next and for each digit puts the same amount of bunnies in each cell. If the digit is 1 or 0, the digit is ignored.

            var currentNextCages = nextCages.ToString()
                    .Replace("0", string.Empty)
                    .Replace("1", string.Empty)
                    //.Replace("-1", string.Empty)
                    .ToString();

            var currentStr = string.Empty;
            for (int j = 0; j < currentNextCages.Length; j++)
            {
                var symbol = currentNextCages[j];
                if (symbol == '-')
                {
                    currentStr = symbol.ToString() + currentNextCages[j + 1];
                }
                else
                {
                    currentStr = symbol.ToString();
                }

                cages.Add(currentStr);
            }

            //7.	Step 1 is repeated for the newly generated cages with bunnies.
            i++;
        }

        Console.WriteLine(string.Join(" ", cages));
    }
}
