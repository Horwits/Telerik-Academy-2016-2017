using System;

class OddOrEvenFinder
{
    static void Main()
    {
        /*You are given n integers (given in a single line, separated by a space).
        Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
        Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
        Examples:
        
        numbers	result
        2 1 1 6 3	yes
        product = 6	
        3 10 4 6 5 1	yes
        product = 60	
        4 3 2 5 2	no
        odd_product = 16	
        even_product = 15*/

        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();

        var inputToArray = input.Split(' ');

        bool numberIsValid = false;
        int oddProduct = 1,
            evenProduct = 1;
        for (int i = 0; i < n; i++)
        {
            int number;
            numberIsValid = int.TryParse(inputToArray[i], out number);
            if (numberIsValid)
            {
                if (i % 2 == 0)
                {
                    evenProduct *= number;
                }
                else
                {
                    oddProduct *= number;
                }
            }
            else
            {
                break;
            }
        }

        if (numberIsValid)
        {
            if (oddProduct == evenProduct)
            {
                Console.WriteLine("yes {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
            }
        }
        else
        {
            Console.WriteLine("Invalid Input!");
        }

    }
}
