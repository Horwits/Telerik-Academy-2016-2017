using System;

class Program
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());

        var currentDate = new DateTime(year, month, day);
        currentDate = currentDate.AddDays(1);

        Console.WriteLine("{0:d.M.yyyy}",currentDate);
    }
}
