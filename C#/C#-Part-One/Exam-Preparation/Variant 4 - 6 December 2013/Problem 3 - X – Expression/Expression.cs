using System;
using System.Text;

class Expression
{
    static void Main()
    {
        string expression = Console.ReadLine();

        decimal result = 0m,
            resultInBracket = 0m;

        char currentOperator = '+',
            currentOperatorInBracket = '+';

        int currentNumber = 0,
            currentNumberInBracket = 0;

        bool isInBracket = false,
            isChanged = false;

        foreach (char symbol in expression)
        {
            if (symbol == '(')
            {
                isInBracket = true;
            }
            else if (symbol == ')')
            {
                isInBracket = false;
                switch (currentOperator)
                {
                    case '+':
                        result += resultInBracket;
                        break;
                    case '-':
                        result -= resultInBracket;
                        break;
                    case '*':
                        result *= resultInBracket;
                        break;
                    case '/':
                        result /= resultInBracket;
                        break;
                }

                resultInBracket = 0;
                currentOperatorInBracket = '+';
            }

            if (!isInBracket)
            {
                if (char.IsDigit(symbol))
                {
                    currentNumber = symbol - '0';
                    isChanged = true;
                }

                if (symbol == '+')
                {
                    currentOperator = '+';
                }
                if (symbol == '-')
                {
                    currentOperator = '-';
                }
                if (symbol == '*')
                {
                    currentOperator = '*';
                }
                if (symbol == '/')
                {
                    currentOperator = '/';
                }

                if (isChanged)
                {
                    switch (currentOperator)
                    {
                        case '+':
                            result += currentNumber;
                            break;
                        case '-':
                            result -= currentNumber;
                            break;
                        case '*':
                            result *= currentNumber;
                            break;
                        case '/':
                            result /= currentNumber;
                            break;
                    }
                }

                isChanged = false;
            }
            else
            {
                if (char.IsDigit(symbol))
                {
                    currentNumberInBracket = symbol - '0';
                    isChanged = true;
                }

                if (symbol == '+')
                {
                    currentOperatorInBracket = '+';
                }
                if (symbol == '-')
                {
                    currentOperatorInBracket = '-';
                }
                if (symbol == '*')
                {
                    currentOperatorInBracket = '*';
                }
                if (symbol == '/')
                {
                    currentOperatorInBracket = '/';
                }

                if (isChanged)
                {
                    switch (currentOperatorInBracket)
                    {
                        case '+':
                            resultInBracket += currentNumberInBracket;
                            break;
                        case '-':
                            resultInBracket -= currentNumberInBracket;
                            break;
                        case '*':
                            resultInBracket *= currentNumberInBracket;
                            break;
                        case '/':
                            resultInBracket /= currentNumberInBracket;
                            break;
                    }
                }

                isChanged = false;
            }
        }

        Console.WriteLine("{0:f2}", result);
    }
}
