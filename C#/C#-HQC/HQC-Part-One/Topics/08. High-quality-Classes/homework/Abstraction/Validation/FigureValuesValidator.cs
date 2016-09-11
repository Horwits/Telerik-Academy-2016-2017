using System;

namespace Abstraction.Validation
{
    internal static class FigureValuesValidator
    {
        internal static void ValidateValue(double value, string message)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }
    }
}