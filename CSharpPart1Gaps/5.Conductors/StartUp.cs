namespace _5.Conductors
{
    //TODO 73/100

    using System;

    class Conductors
    {
        private static int p;
        private static int m;
        private static int currentTicket;

        //ReadInput
        static void ReadInput()
        {
            p = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
        }

        //Solution
        internal static void Solution()
        {
            ReadInput();

            var lastSetBitInP = FindTheLastSetBit(p);
            var result = 0;
            for (int i = 0; i < m; i++)
            {
                currentTicket = int.Parse(Console.ReadLine());
                var lastSetBitInTicket = FindTheLastSetBit(currentTicket);

                var start = 0;
                var end = 0;

                if (lastSetBitInP > lastSetBitInTicket)
                {
                    Console.WriteLine(currentTicket);
                }
                else
                {
                    if (p == 0)
                    {
                        currentTicket = 0;
                    }

                    for (int j = 0, k = 0; j <= lastSetBitInTicket; j++)
                    {
                        var pBitAtPos = FindBitAtPosition(p, k);
                        var currTicketBitAtPos = FindBitAtPosition(currentTicket, j);

                        if (pBitAtPos == currTicketBitAtPos)
                        {
                            if (k == 0)
                            {
                                start = j;
                            }

                            if (k == lastSetBitInP)
                            {
                                end = j;
                                currentTicket = ChangeBitsToZero(currentTicket, start, end);
                                k = 0;
                            }
                            else
                            {
                                k++;
                            }
                        }
                        else
                        {
                            start = 0;
                            end = 0;

                            if (k > 0)
                            {
                                j--;
                            }

                            k = 0;
                        }
                    }
                    // Current Output
                    Console.WriteLine(result = currentTicket);
                }
            }
        }

        public static int FindBitAtPosition(int number, int position)
        {
            int mask = 1 << position;
            int nAndMask = number & mask;
            int bit = nAndMask >> position;

            return bit;
        }

        public static int FindTheLastSetBit(int num)
        {
            var res = 0;
            for (int j = 32 - 1; j >= 0; j--)
            {
                if ((num & (1 << j)) != 0)
                {
                    res = j;
                    break;
                }
            }

            return res;
        }

        public static int ChangeBitsToZero(int number, int start, int end)
        {
            var result = number;

            for (int i = start; i <= end; i++)
            {
                result &= ~(1 << i);
            }

            return result;
        }
    }

    class StartUp
    {
        static void Main(string[] args)
        {
            Conductors.Solution();

            //Console.WriteLine(Conductors.FindTheLastSetBit(int.MaxValue));
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(Conductors.ChangeBitsToZero(469, 0, 3));
        }
    }
}
