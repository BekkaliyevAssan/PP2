using System;
using System.IO;

namespace Directories
{
    class Task1
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            System.IO.File.WriteAllText(@"C:\Users\Fora\source\repos\Week2\Directories\Test.txt", text);
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
