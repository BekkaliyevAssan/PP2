using System;
using System.Text;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderName = @"C:\Users\Fora\source\repos\Week2";
            string path1String = System.IO.Path.Combine(folderName, "path1");
            System.IO.Directory.CreateDirectory(path1String);


            string fileName = "Original.txt";
            path1String = System.IO.Path.Combine(path1String, fileName);
            Console.WriteLine("Path to my new file is {0}\n", path1String);

            // Just for fun)))

            const string specialMessage = "Hello from Hell with love";
            byte[] bArray = Encoding.UTF8.GetBytes(specialMessage);

            //

            using (System.IO.FileStream fs = System.IO.File.Create(path1String))
            {
                for (int i = 0; i < bArray.Length; i++)
                {
                    fs.WriteByte(bArray[i]);
                }
            }
            string path2String = System.IO.Path.Combine(folderName, "path2");
            System.IO.Directory.CreateDirectory(path2String);

            string sourcePath = @"C:\Users\Fora\source\repos\Week2\path1";
            string targetPath = @"C:\Users\Fora\source\repos\Week2\path2";

            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            System.IO.File.Copy(sourceFile, destFile, true);

            // Section to delete the intial one

            if (System.IO.File.Exists(@"C:\Users\Fora\source\repos\Week2\path1\Original.txt"))
            {
                System.IO.File.Delete(@"C:\Users\Fora\source\repos\Week2\path1\Original.txt");
                Console.WriteLine("Hello world"); // this line was just for test))
            }

        }
    }
}
