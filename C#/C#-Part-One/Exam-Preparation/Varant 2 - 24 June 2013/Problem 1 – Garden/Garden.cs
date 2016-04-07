using System;

class Garden
{
    static void Main()
    {
        uint[] inputArray = new uint[11];
        for (int i = 0; i < 11; i++)
        {
            string input = Console.ReadLine();
            inputArray[i] = uint.Parse(input);
        }

        decimal tomatoMoney = inputArray[0] * 0.5m,
            cucumberMoney = inputArray[2] * 0.4m,
            potatoMoney = inputArray[4] * 0.25m,
            carrotMoney = inputArray[6] * 0.6m,
            cabbageMoney = inputArray[8] * 0.3m,
            beansMoney = inputArray[10] * 0.4m;

        decimal totalMoney =
            tomatoMoney +
            cucumberMoney +
            potatoMoney +
            carrotMoney +
            cabbageMoney +
            beansMoney;

        uint tomatoArea = inputArray[1],
            cucumberArea = inputArray[3],
            potatoArea = inputArray[5],
            carrotArea = inputArray[7],
            cabbageArea = inputArray[9];

        uint totalVegetablesArea =
            tomatoArea +
            cucumberArea +
            potatoArea +
            carrotArea +
            cabbageArea;


        uint totalArea = 250;
        if (totalArea > totalVegetablesArea)
        {
            uint beansArea = totalArea - totalVegetablesArea;
            Console.WriteLine("Total costs: {0:f2}", totalMoney);
            Console.WriteLine("Beans area: {0}", beansArea);
        }
        else if (totalVegetablesArea == totalArea)
        {
            Console.WriteLine("Total costs: {0:f2}", totalMoney);
            Console.WriteLine("No area for beans");
        }
        else
        {
            Console.WriteLine("Total costs: {0:f2}", totalMoney);
            Console.WriteLine("Insufficient area");
        }
    }
}
