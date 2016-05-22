using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Solution
{
    static string DecodeGenome(string genome)
    {
        //for ->if is number find out if there is number on the next etc. and add it in some strbuilder, else add s
        int length = genome.Length;
        var symbolsLength = new StringBuilder();
        var decodedGenome = new StringBuilder();

        for (int i = 0; i < length; i++)
        {
            if (char.IsDigit(genome[i]))
            {
                while (char.IsDigit(genome[i]))
                {
                    symbolsLength.Append(genome[i]);
                    i += 1;
                }

                int currentLength = int.Parse(symbolsLength.ToString());

                symbolsLength.Clear();

                decodedGenome.Append(new string(genome[i], currentLength));
            }
            else
            {
                decodedGenome.Append(genome[i]);
            }
        }

        return decodedGenome.ToString();
    }

    static void Main()
    {
        //using (var reader = new StreamReader(@"../../input.txt"))
        // {
        //input 
        var nAndM = Console.ReadLine()
            .Split(' ')
            .Select(x => int.Parse(x))
            .ToArray();

        var encodedGenome = Console.ReadLine();

        int n = nAndM[0];
        int m = nAndM[1];

        var decodedGenome = DecodeGenome(encodedGenome);

        // Output
        int maxRownumber = (int)Math.Ceiling((decimal)decodedGenome.Length / (decimal)n);
        int padSize = maxRownumber.ToString().Length;
        for (int i = 1; i <= maxRownumber; i++)
        {
            StringBuilder line = new StringBuilder();
            line.Append(new string(' ', padSize - i.ToString().Length));
            line.Append(i);
            for (int j = (i - 1) * n; j <= i * n - 1; j++)
            {
                if ((j - (i - 1) * n) % m == 0) line.Append(' ');
                if (j >= decodedGenome.Length) break;
                line.Append(decodedGenome[j]);
            }
            Console.WriteLine(line.ToString());
        }
    }
    //}
}
