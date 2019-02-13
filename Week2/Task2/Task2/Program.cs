using System;
using System.IO;

namespace Week2
{
    class Task2
    {
        static void Main(string[] args)
        {
            string[] lines = Console.ReadLine().Split();//divide numbers as a chars IF THE USER WRITE ALL NUMBERS IN THE CMD
            int[] nums = new int[lines.Length];//array for numbers in the further


            for (int i = 0; i < lines.Length; i++)
                nums[i] = Convert.ToInt32(lines[i]);//converting every char into integer


            int[] ans = new int[nums.Length];//putting numbers into new arr
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
            }//simple algorithm to find out prime numbers and its amount

            string[] ans_string = new string[prime];//new array for answer as a string
            for (int i = 0; i < prime; i++)
            {
                ans_string[i] = Convert.ToString(ans[i]);//putting numbers as a string into string array
            }

            System.IO.File.WriteAllLines(@"C:\Users\Fora\source\repos\Week2\Task2\input.txt", lines);//cout >> all numbers 
            System.Console.Write("Content of the input.txt is ");//shows the content of the input
            foreach (string line in lines)
            {
                Console.Write(line + " ");//leaves free space between chars
            }
            Console.WriteLine();//new line

            
            
            System.IO.File.WriteAllLines(@"C:\Users\Fora\source\repos\Week2\Task2\output.txt", ans_string);//cout >> the final answer
            System.Console.Write("Content of the input.txt is ");//shows the content of the output
            foreach (string anss in ans_string)
            {
                Console.Write(anss + " ");//free space
            }

        }
    }
}
