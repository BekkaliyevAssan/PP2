using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s = Console.ReadLine().Split();
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(s[i]);
            }
            int prime = 0;
            int[] ans = new int[n];
            for (int i = 0; i < n; i++)
            {
                int del = 0;
                for (int j = 1; j <= a[i]; j++)
                {
                    if (a[i] % j == 0)
                        del++;
                }
                if (del == 2)
                {
                    ans[prime] = a[i];
                    prime++;
                }
            }
            Console.WriteLine(prime);
            for (int i = 0; i < prime; i++)
                Console.Write(ans[i] + " ");
        }
    }
}
