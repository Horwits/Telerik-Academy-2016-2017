namespace BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray64 : IEnumerable<int>
    {
        private const int Length = 64;

        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        public ulong Number { get; set; }

        public int this[int position]
        {
            get
            {
                return (int)(this.Number >> position) & 1;
            }

            set
            {
                if (position < 0 || position >= 64)
                {
                    throw new IndexOutOfRangeException("Index cannot be bigger than 64 and less than 0.");
                }

                if (((int)(this.Number >> position) & 1) != value)
                {
                    this.Number ^= 1ul << position;
                }
            }
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !first.Equals(second);
        }

        public override bool Equals(object obj)
        {
            return this.Number.Equals((obj as BitArray64).Number);
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode() ^ this.Number.GetHashCode();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = Length - 1; i >= 0; i--)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            var printInfo = new StringBuilder();

            foreach (var item in this)
            {
                printInfo.Append(item);
            }

            return printInfo.ToString();
        }
    }
}