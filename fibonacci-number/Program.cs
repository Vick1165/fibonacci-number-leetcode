using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fibonacci(4));
        }


        public static int fibonacci(int N)
        {
            if (N <= 1)
                return N;

            int a = 0, b = 1;

            for (int i = 2; i <= N; i++)
            {
                int sum = a + b;
                a = b;
                b = sum;
            }
            return b;
        }
    }
}
