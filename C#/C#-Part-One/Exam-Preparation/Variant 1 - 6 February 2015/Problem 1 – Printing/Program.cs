using System;

class Program
{
    static void Main()
    {
        int numberOfStudents = int.Parse(Console.ReadLine());
        int numberOfPapersheet = int.Parse(Console.ReadLine());
        decimal priceOfARealm = decimal.Parse(Console.ReadLine());

        int totalSheetsOfPaper = numberOfStudents * numberOfPapersheet;
        decimal realms = totalSheetsOfPaper / 500m;
        decimal amountOfMoney = realms * priceOfARealm;

        Console.WriteLine("{0:f2}", amountOfMoney);
    }
}
