using System;

class DayOfWeekGenerator
{
    public static void  PrintWhatDayIsTodayOnConsole()
    {
        DateTime today = DateTime.Now;
        Console.WriteLine(today.DayOfWeek);
    }

    static void Main()
    {
        PrintWhatDayIsTodayOnConsole();
    }
}
