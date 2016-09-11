namespace Methods
{
    using System;

    using Printers;
    using Utils;

    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine(MathUtils.CalculateTriangleArea(3, 4, 5));
            
            Console.WriteLine(MathUtils.GetNumberToEnglishWord(5));
            
            Console.WriteLine(MathUtils.GetMaxNumberInArray(5, -1, 3, 2, 14, 2, 3));

            ConsolePrinter.PrintToConsoleAsNumberByGivenFormat(1.3, "f");
            ConsolePrinter.PrintToConsoleAsNumberByGivenFormat(0.75, "%");
            ConsolePrinter.PrintToConsoleAsNumberByGivenFormat(2.30, "r");

            bool horizontal, vertical;
            Console.WriteLine(MathUtils.CalcDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student
            {
                FirstName = "Peter",
                LastName = "Ivanov",
                OtherInfo = "From Sofia, born at 17.03.1992"
            };

            Student stella = new Student
            {
                FirstName = "Stella",
                LastName = "Markova",
                OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993"
            };

            Console.WriteLine($"{peter.FirstName} older than {stella.FirstName} -> {peter.IsOlderThan(stella)}");
        }
    }
}
