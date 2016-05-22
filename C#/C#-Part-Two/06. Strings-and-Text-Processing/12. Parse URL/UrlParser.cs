using System;

class UrlParser
{
    static void Main()
    {
        string text = Console.ReadLine();

        int indexOfTwoSlashes = text.IndexOf("//");
        string protocol = text.Substring(0, indexOfTwoSlashes);
        Console.WriteLine("[protocol] = {0}", protocol.TrimEnd(':'));

        int indexOfOneSlash = text.IndexOf('/', indexOfTwoSlashes + 2);
        string server = text.Substring(indexOfTwoSlashes + 2, indexOfOneSlash - indexOfTwoSlashes - 2);
        Console.WriteLine("[server] = {0}", server);

        string resource = text.Substring(indexOfOneSlash);
        Console.WriteLine("[resource] = {0}", resource);

    }
}
