using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());
            numbers[i] = currentNum;
        }

        int occurance = 0,
            maxOccurance = 0,
            mostFreaquentNumber = 0;

        for (int i = 0; i < n; i++)
        {
            int currentNum = numbers[i];
            for (int j = 0; j < n; j++)
            {
                if (currentNum == numbers[j])
                {
                    occurance++;
                }

                if (occurance > maxOccurance)
                {
                    maxOccurance = occurance;
                    mostFreaquentNumber = currentNum;
                }
            }

            occurance = 0;
        }

        Console.WriteLine("{0} ({1} times)", mostFreaquentNumber, maxOccurance);
    }
}
