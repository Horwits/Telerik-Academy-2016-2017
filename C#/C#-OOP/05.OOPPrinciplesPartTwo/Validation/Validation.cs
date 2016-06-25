namespace Validation
{
    using System;

    public static class Validation
    {
        public static void ValidateDouble(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException();
            }
        }

        public static void ValidateDecimal(decimal value)
        {
            if (value <= 0)
            {
                throw new ArgumentException();
            }
        }

        public static void ValidateMonth(uint month)
        {
            if (month > 12 && month < 1)
            {
                throw new FormatException();
            }
        }
    }
}
