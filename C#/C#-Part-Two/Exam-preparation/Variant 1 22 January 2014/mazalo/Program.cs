﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace mazalo
{
    class Program
    {
        static void Main(string[] args)
        {
            var cages = new List<int>()
            {
                54,
                39,
                28,
                39,
                63,
                49,
                64,
                64,
                60,
                48,
                74,
                52,
                50,
                13,
                84,
                56,
                97,
                8 ,
                19,
                87,
                49,
                81,
                94,
                74,
                16,
                84,
                62,
                66,
                21,
                8 ,
                68,
                32,
                97,
                11,
                9 ,
                56,
                43,
                49,
                27,
                70,
                8 ,
                71,
                81,
                28,
                33,
                59,
                57,
                49,
                51,
                28,
                34,
                78,
                78,
                85,
                94,
                73,
                45,
                54,
                24,
                78,
                86,
                98,
                45,
                53,
                79,
                43,
                55,
                40,
                5 ,
                29,
                14,
                50,
                80,
                49,
                80,
                78,
                2 ,
                68,
                42,
                57,
                29,
                14,
                17,
                93,
                74,
                90,
                53,
                13,
                17,
                36,
                12,
                88,
                26,
                48,
                83,
                10,
                28,
                29,
                48,
                89
            };

            BigInteger sum = 1;
            for (int i = 1; i < 54; i++)
            {
                sum *= cages[i];
            }

            Console.WriteLine(sum);
        }
    }
}
