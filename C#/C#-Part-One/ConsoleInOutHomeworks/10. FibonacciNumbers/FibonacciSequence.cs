using System;

class FibonacciSequence
{
    static void Main()
    {
        string inputNumber = Console.ReadLine();

        int length;
        bool inputIsValid = int.TryParse(inputNumber, out length);
        if (inputIsValid)
        {
            //Console.WriteLine("First {0} members of the Fibonacci sequence are: ", length);

            int a = 0, b = 1, c = 0;
            Console.Write("{0} ,{1}", a, b);

            for (int i = 2; i < length; i++)
            {
                c = a + b;
                Console.Write(" ,{0}", c);
                a = b;
                b = c;
            }

            Console.WriteLine();
        }
        else
        {
            string errorMessage = "Please, enter a valid number.";
            Console.WriteLine(errorMessage);
        }
    }
}

