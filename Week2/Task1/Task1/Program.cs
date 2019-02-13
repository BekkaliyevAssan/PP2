using System;
using System.IO;

namespace Directories
{
    class Task1
    {
        static void Main(string[] args)
        {
            //string text = Console.ReadLine(); IN CASE, IF I SHOULD GET DATA FROM CONSOLE
            string text = System.IO.File.ReadAllText(@"C:\Users\Fora\source\repos\Week2\TestInput.txt");//This method reads all of the info from the txt
            System.IO.File.WriteAllText(@"C:\Users\Fora\source\repos\Week2\TestOutput.txt", text);//Comes with the answer to the Output text
            System.Console.WriteLine("Content of the Test.txt is  =  {0}", text);//This extra row shows content of the input
            char[] ch = text.ToCharArray();//Converts the word into the chars and put it in the array
            Array.Reverse(ch);//Reverse
            string reverse = new string(ch);//Making up a new string with reversed chars
            if (reverse == text)
                Console.WriteLine("True");//Output on console
            else
                Console.WriteLine("False");//Output on console

        }
    }
}
