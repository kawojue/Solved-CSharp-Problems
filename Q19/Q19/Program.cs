using System;
using System.IO;

namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the path of the source file: ");
            string sourceFileName = Console.ReadLine();

            Console.Write("\nEnter the path of the destination file: ");
            string destFileName = Console.ReadLine();

            // Read the content of the source file.
            string content = File.ReadAllText(sourceFileName);

            // Write the content to the destination file.
            File.WriteAllText(destFileName, content);

            Console.WriteLine("\n\nFile copied successfully.");
        }
    }
}
