using System;

class Program
{
    static void Main()
    {
        float n1 = float.Parse(Console.ReadLine()) * 0.05f;
        float n2 = float.Parse(Console.ReadLine()) * 0.1f;
        float n3 = float.Parse(Console.ReadLine()) * 0.2f;
        float n4 = float.Parse(Console.ReadLine()) * 0.5f;
        float n5 = float.Parse(Console.ReadLine());
        float amount = float.Parse(Console.ReadLine());
        float price = float.Parse(Console.ReadLine());

        float total = n1 + n2 + n3 + n4 + n5;

        bool areEnoughMoney = amount - price >= 0;

        float change = total - (amount - price);


        if (areEnoughMoney && change > 0)
        {
            Console.WriteLine("Yes {0:f2}", change);
        }
        else if (!areEnoughMoney)
        {
            Console.WriteLine("More {0:f2}", price - amount);
        }
        else
        {
            Console.WriteLine("No {0:f2}", amount - (total + price));
        }
    }
}
