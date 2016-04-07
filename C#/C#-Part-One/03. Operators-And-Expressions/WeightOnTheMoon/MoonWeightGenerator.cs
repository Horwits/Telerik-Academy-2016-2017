using System;

class MoonWeightGenerator
{
    static void Main()
    {
        double weight;
        bool inputIsCorrect = double.TryParse(Console.ReadLine(), out weight);

        if (inputIsCorrect)
        {
            var weightOnTheMoon = weight * 0.17;
            Console.WriteLine("{0:f3}", weightOnTheMoon);
        }
        else
        {
            Console.WriteLine("Please, enter valid weight!");
        }
    }
}
