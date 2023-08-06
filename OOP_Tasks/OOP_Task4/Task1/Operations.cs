using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec4_T1
{
    internal class Operations
    {
        public static int sum(int[] arr, int size)
        {
            int sum = 0;

            for (int i = 0; i < size; i++)
                sum += arr[i];

            return (sum);
        }
        public static int max(int[] arr, int size)
        {
            int max = arr[0];

            for (int i = 1; i < size; i++)
                if (arr[i] > max)
                    max = arr[i];

            return (max);
        }
        public static int min(int[] arr, int size)
        {
            int min = arr[0];

            for (int i = 1; i < size; i++)
                if (arr[i] < min)
                    min = arr[i];

            return (min);
        }
        public static int positive(int[] arr, int size)
        {
            int p = 0;

            for (int i = 0; i < size; i++)
                if (arr[i] > 0)
                    p++;

            return (p);
        }
        public static int negative(int[] arr, int size)
        {
            int n = 0;

            for (int i = 0; i < size; i++)
                if (arr[i] < 0)
                    n++;

            return (n);
        }
        public static int even(int[] arr, int size)
        {
            int e = 0;

            for (int i = 0; i < size; i++)
                if (arr[i] % 2 == 0)
                    e++;
            return (e);
        }
        public static int odd(int[] arr, int size)
        {
            int o = 0;

            for (int i = 0; i < size; i++)
                if (arr[i] % 2 == 1)
                    o++;
            return (o);
        }
    }
}
