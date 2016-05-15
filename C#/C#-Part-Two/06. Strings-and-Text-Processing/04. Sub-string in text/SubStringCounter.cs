using System;

class SubStringCounter
{
    static int CountHowManyTimesStringOccursInText(string pattern, string text)
    {
        int index = 0;
        int counter = 0;
        int found = 0;

        while (found != -1)
        {
            found = text.IndexOf(pattern, index, StringComparison.CurrentCultureIgnoreCase);

            if (found > 0)
            {
                counter++;
            }

            index = found + 1;
        }

        return counter;
    }

    static void Main()
    {
        string pattern = Console.ReadLine();
        string text = Console.ReadLine();

        int times = CountHowManyTimesStringOccursInText(pattern, text);
        Console.WriteLine(times);
    }
}
