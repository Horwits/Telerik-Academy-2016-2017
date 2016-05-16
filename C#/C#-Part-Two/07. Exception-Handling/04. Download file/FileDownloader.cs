using System;
using System.Net;

class FileDownloader
{
    static void Main()
    {
        try
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://telerikacademy.com/Content/Images/news-img01.png", "news-img01.png");
            }
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The method has been called simultaneously on multiple threads.");
        }
        catch (WebException)
        {
            Console.WriteLine("The method has been called simultaneously on multiple threads.");
            Console.WriteLine("-or-");
            Console.WriteLine("filename is null or Empty.");
            Console.WriteLine("-or-");
            Console.WriteLine("The file does not exist.");
            Console.WriteLine("-or-");
            Console.WriteLine("An error occurred while downloading data.");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The address parameter is null.");
        }
    }
}
