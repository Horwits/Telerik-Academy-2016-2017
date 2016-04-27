using System;
using System.IO;

class Program
{
    static void Main()
    {
        checked
        {
            var reader = new StreamReader(@"C:\Users\Horwi\Desktop\All exam tasks\04. 2015-winter\Variant 1 (2015-02-02)\Problem 2\test.020.in.txt");
            using (reader)
            {
                ushort m = ushort.Parse(reader.ReadLine());
                string text = reader.ReadLine();

                long result = 0;
                foreach (var sym in text)
                {
                    if (sym == '@')
                    {
                        break;
                    }
                    else if (char.IsDigit(sym))
                    {
                        result *= sym - '0';
                    }
                    else if (char.IsLetter(sym))
                    {
                        if (sym >= 'a' && sym <= 'z')
                        {
                            result += sym - 'a';
                        }
                        else
                        {
                            result += sym - 'A';
                        }
                    }
                    else
                    {
                        result %= m;
                    }
                }

                Console.WriteLine(result);
            }
        }
    }
}
