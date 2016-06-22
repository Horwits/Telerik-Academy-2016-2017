namespace Extensions.StringBuilder
{
    using System;
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder originalSb, int index, int length)
        {
            bool isIndexLessThanZero = index < 0,
                isIndexEqualOrMoreThanArgumentLength = index >= originalSb.Length,
                isIndexPlusLengthEqualOrMoreThanArgumentLength = (index + length >= originalSb.Length);

            if ((isIndexLessThanZero || isIndexEqualOrMoreThanArgumentLength) || isIndexPlusLengthEqualOrMoreThanArgumentLength)
            {
                throw new IndexOutOfRangeException();
            }

            var result = new StringBuilder();

            for (int i = index; i < length; i++)
            {
                result.Append(originalSb[i]);
            }

            return result;
        }
    }
}
