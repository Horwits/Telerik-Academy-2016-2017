using System;

class Solution
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int result = 0;
        if (n <= 10 && n < 6)
        {
            result = n + 1;
        }
        else if(n <= 10 && n == 6)
        {
            result = n + 4;
        }
        else if (n < 100 && n > 10 && n % 10 == 6)
        {
            if (n != 66)
            {
                result = n + 4;
            }
            else
            {
                result = 100;
            }
        }
        else if (n <= 1000 && n >= 100 && n % 10 == 6)
        {
            if (n == 666)
            {
                result = 1000;
            }
            else if ((n / 10) % 10 == 6)
            {
                result = (n / 100 + 1) * 100;
            }
            else if((n / 10) % 10 != 6)
            {
                result = n + 4;
            }
        }
        else
        {
            result = n + 1;
        }

        Console.WriteLine(result);
    }
}
