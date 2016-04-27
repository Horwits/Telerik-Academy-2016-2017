using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var s = int.Parse(Console.ReadLine());
        var sToBin = Convert.ToString(s, 2);
        //var sToBin = Convert.ToString(5, 2);
        int length = sToBin.Length;
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var currentNum = int.Parse(Console.ReadLine());
            if (s > currentNum)
            {
                continue;
            }
            var currentNumToBin = Convert.ToString(currentNum, 2).PadLeft(30, '0');

            //var currentNumToBin = Convert.ToString(469, 2).PadLeft(30, '0');
            int currentNumLength = currentNumToBin.Length;
            var copy = new StringBuilder();
            int index = 0;
            while ((index = currentNumToBin.LastIndexOf(sToBin)) != -1)
            {
                index = currentNumToBin.LastIndexOf(sToBin);

                string firstPart = currentNumToBin.Substring(0, index);
                string middlePart = new string('0', length);
                string lastPart = currentNumToBin.Substring(index + length, currentNumLength - (index + length));
                copy.Append(firstPart).Append(middlePart).Append(lastPart);

                currentNumToBin = copy.ToString();
                copy.Clear();
                index--;
            }

            Console.WriteLine(Convert.ToInt32(currentNumToBin, 2));
        }
    }
}

