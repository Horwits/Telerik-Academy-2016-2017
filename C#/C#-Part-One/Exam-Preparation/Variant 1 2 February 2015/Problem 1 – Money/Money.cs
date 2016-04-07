using System;

class Money
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());

        int oneRealm = 400;

        decimal totalSheets = n * s;
        decimal neededRealms = totalSheets / oneRealm;
        decimal neededMoney = neededRealms * p;

        Console.WriteLine("{0:f3}", neededMoney);
    }
}
