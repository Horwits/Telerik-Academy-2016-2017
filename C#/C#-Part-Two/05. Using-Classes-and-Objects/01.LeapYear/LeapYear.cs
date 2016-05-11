using System;

class LeapYear
{
    static void Main()
    {
        var year = int.Parse(Console.ReadLine());

        var isLeap = DateTime.IsLeapYear(year);

        if (isLeap)
        {
            Console.WriteLine("Leap");
        }
        else
        {
            Console.WriteLine("Common");
        }
    }
}
