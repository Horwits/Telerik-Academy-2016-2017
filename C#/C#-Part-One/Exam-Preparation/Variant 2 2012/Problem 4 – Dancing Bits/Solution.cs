using System;
using System.Text;

class Solution
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());

        int n = int.Parse(Console.ReadLine());

        var concatenated = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            concatenated.Append(Convert.ToString(int.Parse(Console.ReadLine()), 2));
        }

        Console.WriteLine(concatenated.ToString());

        int length = concatenated.Length,
            counter = 1,
            sequenceCounter = 0;

        if (k == 1)
        {
            sequenceCounter = length;
        }
        else
        {
            for (int i = 0; i < length - 1; i++)
            {
                int j = i + 1;
                if (j < length)
                {
                    if (concatenated[i] == concatenated[j])
                    {
                        counter++;
                        if (j + 1 < length)
                        {
                            if (counter == k)
                            {
                                if (concatenated[i] != concatenated[j + 1])
                                {
                                    sequenceCounter++;
                                }
                            }
                        }
                    }
                    else
                    {
                        counter = 1;
                    }
                }
            }
        }

        Console.WriteLine(sequenceCounter);
    }
}
