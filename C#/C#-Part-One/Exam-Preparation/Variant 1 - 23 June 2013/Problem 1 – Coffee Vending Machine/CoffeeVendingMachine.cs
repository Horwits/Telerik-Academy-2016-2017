using System;
using System.Diagnostics;

class CoffeeVendingMachine
{
    static void Main()
    {
        //input
        decimal [] input = new decimal [7];
        for (int i = 0; i < 7; i++)
        {
            decimal userInput = decimal.Parse(Console.ReadLine());
            input[i] = userInput;
        }

        decimal trayOneAmount = input[0] * 0.05m;
        decimal trayTwoAmount = input[1] * 0.1m;
        decimal trayThreeAmount = input[2] * 0.2m;
        decimal trayFourAmount =input[3]* 0.5m;
        decimal trayFiveAmount =input[4] * 1;
        decimal developerMoney = input[5];
        decimal priceOfSelectedDrink = input[6];

        decimal allMoneyInmachine = trayOneAmount +
                                    trayTwoAmount +
                                    trayThreeAmount +
                                    trayFourAmount +
                                    trayFiveAmount;


        decimal change = developerMoney - priceOfSelectedDrink;
        if (developerMoney >= priceOfSelectedDrink)
        {
            if (allMoneyInmachine >= change)
            {
                Console.WriteLine("{0} {1:f2}", "Yes", allMoneyInmachine - change);
            }
            else
            {
                Console.WriteLine("{0} {1:f2}", "No", change - allMoneyInmachine);
            }
        }
        if (priceOfSelectedDrink > developerMoney)
        {
            decimal more = priceOfSelectedDrink - developerMoney;
            Console.WriteLine("{0} {1:f2}","More", more);
        }
    }
}
