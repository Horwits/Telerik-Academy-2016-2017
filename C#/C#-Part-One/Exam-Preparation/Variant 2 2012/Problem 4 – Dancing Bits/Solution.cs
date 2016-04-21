using System;
using System.IO;
using System.Text;

class Solution
{
    static void Main()
    {
        var reader = new StreamReader(@"..\..\test.txt");
        using (reader)
        {
            int k = int.Parse(reader.ReadLine());

            int n = int.Parse(reader.ReadLine());

            var concatenated = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                concatenated.Append(Convert.ToString(int.Parse(reader.ReadLine()), 2));
            }

            Console.WriteLine(concatenated.ToString());

        }
    }
}
