using System;

class Program
{
    static int FIndAllPositiveDivisorsSum(int n)
    {
        int sum = 0;

        for (int j = 1; j <= n; j++)
        {
            if (n % j == 0 && j % 2 == 0)
            {
                sum += j;
            }
        }

        return sum;
    }

    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = a; i <= b; i++)
        {
            sum += FIndAllPositiveDivisorsSum(i); 
        }

        Console.WriteLine(sum);
    }
}
