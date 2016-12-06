namespace Validation
{
    using System;

    public static class ValidationUtils
    {
        public static void ValidateString(string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Value cannot be empty.");
            }

            if (value.Length < 2)
            {
                throw new FormatException("Value has to be bigger than 2 symbols");
            }
        }

        public static void ValidateUInt(uint value)
        {
            if (value < 1)
            {
                throw new ArgumentOutOfRangeException("Value cannot be equal to zero.");
            }
        }

        public static void ValidateDecimal(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Value cannot be less than zero.");
            }
        }

        public static string ValidateCommentString(string comment)
        {
            if (string.IsNullOrEmpty(comment))
            {
                return comment = "No comment is added yet.";
            }

            return comment;
        }
    }
}
