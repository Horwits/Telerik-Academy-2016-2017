using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UrlParser
{
    static void Main()
    {
        string text = Console.ReadLine();

        var splitted = text.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("[protocol] = {0}//", splitted[0]);
        Console.WriteLine("[server] = {0}", splitted[1]);
        Console.WriteLine("[resource] = {0}", string.Join("/", splitted, 2, splitted.Length - 2));
    }
}
