using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public static int[] dublicate(int[] arr, int n)
        {
            int[] arr2 = new int[n * 2];
            for (int i = 0, j = 0; i < n; i++)
            {
                arr2[j] = arr[i];
                j++;
                arr2[j] = arr[i];
                j++;
            }
            return arr2;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            string[] list = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(list[i]);
            }
            int[] arr2 = new int[n * 2];
            arr2 = dublicate(arr, n);
            
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write(arr2[i] + " ");
            }
        }
    }
}
