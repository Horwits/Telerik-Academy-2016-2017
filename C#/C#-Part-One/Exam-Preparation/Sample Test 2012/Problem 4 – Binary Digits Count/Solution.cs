using System;
using System.IO;
using System.Text;

class Solution
{
    static void Main()
    {
        //char bitValue = (char)(Console.Read());
        //using (var reader = new StreamReader(@"../../test.txt"))
        //{
            string bitValueNum = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            var binary = new StringBuilder();
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                var num = Convert.ToString(long.Parse(Console.ReadLine()), 2);
                binary.Append(num);

                char bitValue = bitValueNum[0];
                foreach (var symbol in binary.ToString())
                {
                    if (symbol == bitValue)
                    {
                        counter++;
                    }
                }

                Console.WriteLine(counter);

                counter = 0;
                binary.Clear();
            }
        }
    //}
}
