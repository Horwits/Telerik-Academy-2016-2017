using System;

class LeapYear
{
    static void Main()
    {
        var year = int.Parse(Console.ReadLine());
        
        var isLeap = DateTime.IsLeapYear(year);
        Console.WriteLine(isLeap);
    }
}
