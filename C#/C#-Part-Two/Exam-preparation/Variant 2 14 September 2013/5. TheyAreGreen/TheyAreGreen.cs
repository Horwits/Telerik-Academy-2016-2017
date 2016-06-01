using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TheyAreGreen
{
    //THIS IS NOT THE SOLUTION
    public static IEnumerable<String> GenerateStrings(IEnumerable<char> characters, int length)
    {
        if (length > 0)
        {
            foreach (char c in characters)
            {
                foreach (String suffix in GenerateStrings(characters, length - 1))
                {
                    var currentW = c + suffix;
                    if (currentW.Length > 1)
                    {
                        if (currentW[0] == currentW[1])
                        {
                            continue;
                        }
                    }
                    

                    yield return c + suffix;
                }
            }
        }
        else
        {
            yield return string.Empty;
        }
    }

    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var chars = new List<char>();
        var res = new List<string>();
        for (int i = 0; i < n; i++)
        {
            chars.Add(Console.ReadLine()[0]);
        }

        for (int i = 1; i < n; i++)
        {
            res.AddRange(GenerateStrings(chars, i));
        }

        Console.WriteLine(res.Count);
    }
}
