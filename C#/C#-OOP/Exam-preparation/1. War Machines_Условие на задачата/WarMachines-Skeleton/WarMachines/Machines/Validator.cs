namespace WarMachines.Machines
{
    using System;

    internal static class Validator
    {
        internal static void ValidateString(string value, string name)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException(string.Format("{0} cannot be null or empty.", name));
            }
        }

        internal static void ValidateNull<T>(T value, string name)
            where T : class
        {
            if (value == null)
            {
                throw new ArgumentNullException(string.Format("{0}' cannot be null.", name));
            }
        }
    }
}