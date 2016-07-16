namespace BobbyAvocadoto
{
    using System;

    public class BobbyAvocadoto
    {
        public static uint head;
        public static uint combs;
        public static uint comb;

        public static void Solution()
        {
            ReadInput();

            uint result = 0;
            var counter = 0;
            var maxCounter = 0;
            var headLen = FindTheLastSetBit(head);

            for (int i = 0; i < combs; i++)
            {
                var comb = uint.Parse(Console.ReadLine());

                var combsLen = FindTheLastSetBit(comb);
                for (int j = 0, k = 0; j < combsLen || k < headLen; j++, k++)
                {
                    if ((comb & (1 << j)) != 0 && (head & (1 << k)) != 1 || (comb & (1 << j)) != 1 && (head & (1 << k)) != 0)
                    {
                        counter++;
                    }

                    if (((comb & (1 << j)) != 0 && (head & (1 << k)) != 0))
                    {
                        break;
                    }
                }

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    result = comb;
                }

                counter = 0;
            }

            // output
            Console.WriteLine(result);
        }

        private static int FindTheLastSetBit(uint num)
        {
            var result = 0;
            for (int i = 32 - 1; i >= 0; i--)
            {
                if ((num & (1 << i)) != 0)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }

        private static void ReadInput()
        {
            head = uint.Parse(Console.ReadLine());
            combs = uint.Parse(Console.ReadLine());
        }
    }

    // 1001
    // 0110
    // 0011

    class Program
    {
        static void Main(string[] args)
        {
            BobbyAvocadoto.Solution();
        }
    }
}
