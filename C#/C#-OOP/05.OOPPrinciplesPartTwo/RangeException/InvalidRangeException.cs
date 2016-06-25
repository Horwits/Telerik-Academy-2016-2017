namespace RangeException
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
        where T : IComparable<T>
    {
        public InvalidRangeException(string message, T start, T end)
            : base(message)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start { get; set; }

        public T End { get; set; }
    }
}