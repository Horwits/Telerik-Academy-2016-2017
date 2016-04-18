using System;

class SearchInBItsSolution
{
    static int FindOccurancesOfStringInString(string text, string toBeFound)
    {
        int occurances = 0;
        int index = 0;

        while ((index = text.IndexOf(toBeFound, index)) != -1)
        {
            index = text.IndexOf(toBeFound, index);
            if (index != -1)
            {
                index++;
            }

            occurances++;
        } 

        return occurances;
    }

    static void Main()
    {
        int s = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());


        int occurances = 0;
        for (int i = 0; i < n; i++)
        {
            string binary = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(30, '0');

            string toBeFound = Convert.ToString(s, 2).PadLeft(4, '0');

            occurances += FindOccurancesOfStringInString(binary, toBeFound);
        }

        Console.WriteLine(occurances);
    }
}
