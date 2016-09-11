namespace Methods.Printers
{
    using System;

    internal class ConsolePrinter
    {
        internal static void PrintToConsoleAsNumberByGivenFormat(object number, string format)
        {
            if (number == null)
            {
                throw new ArgumentNullException(nameof(number));
            }

            if (format == null)
            {
                throw new ArgumentNullException(nameof(format));
            }

            var output = string.Empty;
            if (format == "f")
            {
                output = $"{number:f2}";
            }
            else if (format == "%")
            {
                output = $"{number:p0}";
            }
            else if (format == "r")
            {
                output = $"{number,8}";
            }

            Console.WriteLine(output);
        }
    }
}