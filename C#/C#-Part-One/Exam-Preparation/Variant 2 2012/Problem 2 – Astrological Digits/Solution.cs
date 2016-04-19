using System;

class Solution
{
    static void Main()
    {
        string n = Console.ReadLine();

        int result = 0,
            position = 0,
            length = n.Length;

        while (true)
        {
            char digit = n[position];

            bool isChanged = false;

            if (digit >= '0' && digit <= '9')
            {
                result += digit - '0';
            }

            if (position == length - 1)
            {
                if (result > 9)
                {
                    n = result.ToString();

                    position = 0;
                    isChanged = true;

                    result = 0;
                    length = n.Length;
                }
                else
                {
                    Console.WriteLine(result);
                    break;
                }
            }

            if (!isChanged)
            {
                position++;
            }
        }
    }
}
