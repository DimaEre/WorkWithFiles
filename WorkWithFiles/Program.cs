using System.IO;
using System;

namespace Program
{
    class Програма
    {
        static void Main(string[] args)
        {
            string? text;
            text = Console.ReadLine();
            StreamWriter print = new StreamWriter("File.txt", false);
            print.Write(text);
            print.Close();  
        }
    }
}
