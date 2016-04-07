using System;

class Program
{
    static void Main()
    {
        var n = short.Parse(Console.ReadLine());

        var numbers = new short[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = short.Parse(Console.ReadLine());
        }

        int maxCounter = 0;
        int currentMax = 0;
        for (int i = 1, j = 0; i < n && j < n; i = j + 1)
        {
            int currentNum = numbers[j];
            if (currentNum == numbers[i])
            {
                currentMax++;
                if (currentMax > maxCounter)
                {
                    maxCounter = currentMax;
                }
            }
            else
            {
                currentMax = 0;
            }

            j++;
        }

        int maxSequenceLength = maxCounter + 1;
        Console.WriteLine(maxSequenceLength);
        //Console.WriteLine(string.Join(" ,", numbers));
    }
}
