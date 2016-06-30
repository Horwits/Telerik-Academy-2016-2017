namespace SoftwareAcademy
{
    using System;

    internal static class Validation
    {
        internal static void ValidateString(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException();
            }
        }
    }
}