using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec4_T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter size of array: ");
            n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter array elements: ");
            
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("\nOperations on array: ");
            Console.WriteLine("Sum: " + Operations.sum(arr, n));
            Console.WriteLine("Min: " + Operations.min(arr, n));
            Console.WriteLine("Max: " + Operations.max(arr, n));
            Console.WriteLine("Positive: " + Operations.positive(arr, n));
            Console.WriteLine("Negative: " + Operations.negative(arr, n));
            Console.WriteLine("Even: " + Operations.even(arr, n));
            Console.WriteLine("Odd: " + Operations.odd(arr, n));



            /*for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }*/
        }
    }
}
