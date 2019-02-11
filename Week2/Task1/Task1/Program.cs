using System;
using System.IO;

namespace Directories
{
    class Task1
    {
        static void Main(string[] args)
        {
            //string text = Console.ReadLine(); IN CASE, IF I SHOULD GET DATA FROM CONSOLE
            string text = System.IO.File.ReadAllText(@"C:\Users\Fora\source\repos\Week2\TestInput.txt");
            System.IO.File.WriteAllText(@"C:\Users\Fora\source\repos\Week2\TestOutput.txt", text);
            System.Console.WriteLine("Content of the Test.txt is  =  {0}", text);
            char[] ch = text.ToCharArray();
            Array.Reverse(ch);
            string reverse = new string(ch);
            if (reverse == text)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

        }
    }
}
