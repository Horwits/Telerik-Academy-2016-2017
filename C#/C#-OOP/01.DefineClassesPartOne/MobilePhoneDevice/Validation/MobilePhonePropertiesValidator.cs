namespace MobilePhoneDevice.Validation
{
    using System;

    internal static class MobilePhonePropertiesValidator
    {
        internal static void ValidateNames(string name, string errorMessage)
        {
            if (name == " " || name == string.Empty)
            {
                throw new ArgumentException(errorMessage);
            }
        }

        internal static void ValidateNumbers(int number, string errorMessage)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(errorMessage);
            }
        }

        internal static void ValidateNumbers(decimal number, string errorMessage)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(errorMessage);
            }
        }

        internal static void ValidateNumbers(double number, string errorMessage)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(errorMessage);
            }
        }

        internal static void ValidateNumbers(long number, string errorMessage)
        {
            if (number < 0 || number > long.MaxValue)
            {
                throw new ArgumentOutOfRangeException(errorMessage);
            }
        }

        internal static void ValidateCallHistory(int value, int callHistoryCount, string errorMessage)
        {
            if (callHistoryCount < 0 || value >= callHistoryCount)
            {
                throw new ArgumentOutOfRangeException(errorMessage);
            }
        }

        internal static void ValidateAddCall(Call newCall, string errorMessage)
        {
            if (newCall == null)
            {
                throw new ArgumentNullException(errorMessage);
            }
        }

        internal static void ValidatePhoneNumber(string phoneNumber, string errorMessage)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(errorMessage);
            }

            foreach (var symbol in phoneNumber)
            {
                if (symbol == '+' || char.IsDigit(symbol))
                {
                    continue;
                }
                else
                {
                    throw new FormatException(errorMessage);
                }
            }
        }
    }
}
