using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;

class ContentReader
{
    static void PrintAllTextFromFileOnConsole(string path)
    {
        if (!File.Exists(path))
        {
            string createText = "Hello and Welcome" + Environment.NewLine;
            File.WriteAllText(path, createText);
        }

        // This text is always added, making the file longer over time
        // if it is not deleted.
        string appendText = "This is extra text" + Environment.NewLine;
        File.AppendAllText(path, appendText);

        // Open the file to read from.
        string readText = File.ReadAllText(path);
        Console.WriteLine(readText);
    }

    static void Main()
    {
        try
        {
            string path = @"C:\WINDOWS\win.ini";

            PrintAllTextFromFileOnConsole(path);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file specified in path was not found.");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Path is null.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Path is a zero-length string, contains only white space, or contains one or more invalid characters.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path is invalid (for example, it is on an unmapped drive).");
        }
        catch (SecurityException)
        {
            Console.WriteLine("The caller does not have the required permission.");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("path specified a file that is read-only.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Path is in an invalid format.");
        }
    }
}
