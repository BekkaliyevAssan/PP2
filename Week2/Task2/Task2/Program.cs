using System;
using System.IO;

namespace Week2
{
    class Task2
    {
        static void Main(string[] args)
        {
            string[] lines = Console.ReadLine().Split();
            int[] nums = new int[lines.Length];


            for (int i = 0; i < lines.Length; i++)
                nums[i] = Convert.ToInt32(lines[i]);


            int[] ans = new int[nums.Length];
            int prime = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int del = 0;
                for (int j = 1; j <= nums[i]; j++)
                {
                    if (nums[i] % j == 0)
                        del++;
                }
                if (del == 2)
                {
                    ans[prime] = nums[i];
                    prime++;
                }
            }

            string[] ans_string = new string[prime];
            for (int i = 0; i < prime; i++)
            {
                ans_string[i] = Convert.ToString(ans[i]);
            }

            System.IO.File.WriteAllLines(@"C:\Users\Fora\source\repos\Week2\Task2\input.txt", lines);
            System.Console.Write("Content of the input.txt is ");
            foreach (string line in lines)
            {
                Console.Write(line + " ");
            }
            Console.WriteLine();

            System.IO.File.WriteAllLines(@"C:\Users\Fora\source\repos\Week2\Task2\output.txt", ans_string);
            System.Console.Write("Content of the input.txt is ");
            foreach (string anss in ans_string)
            {
                Console.Write(anss + " ");
            }

        }
    }
}
