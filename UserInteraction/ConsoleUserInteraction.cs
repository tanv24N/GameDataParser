using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ConsoleUserInteraction : IUserInterface
{
    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void PrintError(string message)
    {
        Console.WriteLine(message);
        var originalColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = originalColor;

    }
    public string ReadValidFilePathFromUser()
    {
        bool isFilePathValid = false;
        string fileName;
        do
        {

            Console.WriteLine("Enter the name of the file you want to read:");
            fileName = Console.ReadLine();


            if (!File.Exists(fileName))
            {
                Console.WriteLine("The file name cannot be found.");
            }
            else if (fileName == null)
            {
                Console.WriteLine("The file name cannot be null.");
            }
            else if (fileName == string.Empty)
            {
                Console.WriteLine("The file name cannot be empty.");
            }
            else
            {
                isFilePathValid = true;
            }

        } while (!isFilePathValid);
        return fileName;
    }
}
