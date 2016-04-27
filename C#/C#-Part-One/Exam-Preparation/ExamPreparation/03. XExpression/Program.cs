using System;

class Program
{
    static void Main()
    {
        string expression = Console.ReadLine();

        double result = 0,
            resultInBracket = 0;
        char currentOperator = '+',
            operatorInBracket = '+';

        bool isInBracket = false;
        foreach (var symbol in expression)
        {
            if (symbol == '=')
            {
                Console.WriteLine("{0:f2}", result);
                break;
            }
            else if (symbol == '+')
            {
                if (isInBracket)
                {
                    operatorInBracket = '+';
                }
                else
                {
                    currentOperator = '+';
                }

                continue;
            }
            else if (symbol == '-')
            {
                if (isInBracket)
                {
                    operatorInBracket = '-';
                }
                else
                {
                    currentOperator = '-';
                }
                continue;
            }
            else if (symbol == '/')
            {
                if (isInBracket)
                {
                    operatorInBracket = '/';
                }
                else
                {
                    currentOperator = '/';
                }

                continue;
            }
            else if (symbol == '*')
            {
                if (isInBracket)
                {
                    operatorInBracket = '*';
                }
                else
                {
                    currentOperator = '*';
                }

                continue;
            }
            else if (symbol == '(')
            {
                isInBracket = true;
                continue;
            }
            else if (symbol == ')')
            {
                isInBracket = false;
                if (currentOperator == '+' && !isInBracket)
                {
                    result += resultInBracket;
                }
                else if (currentOperator == '-' && !isInBracket)
                {
                    result -= resultInBracket;
                }
                else if (currentOperator == '/' && !isInBracket)
                {
                    result /= resultInBracket;
                }
                else if (currentOperator == '*' && !isInBracket)
                {
                    result *= resultInBracket;
                }

                operatorInBracket = '+';
                resultInBracket = 0;
                continue;
            }

            //result
            if (currentOperator == '+' && !isInBracket)
            {
                result += symbol - '0';
            }
            else if (currentOperator == '-' && !isInBracket)
            {
                result -= symbol - '0';
            }
            else if (currentOperator == '/' && !isInBracket)
            {
                result /= symbol - '0';
            }
            else if (currentOperator == '*' && !isInBracket)
            {
                result *= symbol - '0';
            }

            //result in bracket
            if (operatorInBracket == '+')
            {
                if (isInBracket)
                {
                    resultInBracket += symbol - '0';
                }
            }
            else if (operatorInBracket == '-')
            {
                if (isInBracket)
                {
                    resultInBracket -= symbol - '0';
                }
            }
            else if (operatorInBracket == '/')
            {
                if (isInBracket)
                {
                    resultInBracket /= symbol - '0';
                }
            }
            else if (operatorInBracket == '*')
            {
                if (isInBracket)
                {
                    resultInBracket *= symbol - '0';
                }
            }
        }
    }
}
