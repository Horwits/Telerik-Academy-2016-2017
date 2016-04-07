using System;

class DrunkenNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var rounds = new string[n];

        var mitkoSum = 0;
        var vladkoSum = 0;

        for (int i = 0; i < n; i++)
        {
            string drunkenNumberToString = Console.ReadLine();

            int drunkenNumber = int.Parse(drunkenNumberToString);

            if (drunkenNumber < 0)
            {
                drunkenNumber *= -1;
            }

            var length = drunkenNumber.ToString().Length;

            int counter = 1;
            while (drunkenNumber != 0)
            {
                int digit = drunkenNumber % 10;
                if (length % 2 == 0)
                {
                    if (counter <= (length / 2))
                    {
                        vladkoSum += digit;
                    }

                    if (counter >= ((length / 2) + 1))
                    {
                        mitkoSum += digit;
                    }
                }
                else
                {
                    if (counter <= (length / 2))
                    {
                        vladkoSum += digit;
                    }
                    else if (counter > ((length / 2) + 1))
                    {
                        mitkoSum += digit;
                    }
                    else
                    {
                        mitkoSum += digit;
                        vladkoSum += digit;
                    }
                }

                counter++;
                drunkenNumber /= 10;
            }
        }

        //output
        if (mitkoSum > vladkoSum)
        {
            Console.WriteLine("{0} {1}", "M", mitkoSum - vladkoSum);
        }
        else if (vladkoSum > mitkoSum)
        {
            Console.WriteLine("{0} {1}", "V", vladkoSum - mitkoSum);
        }
        else
        {
            Console.WriteLine("{0} {1}", "No", vladkoSum + mitkoSum);
        }
    }
}
