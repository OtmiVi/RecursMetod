using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursMetod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonachi(7));
            Console.WriteLine(Sum(3));
            Console.Write(Factorial(5));
            Console.ReadKey();
        }
        static int Factorial(int x)
        {
            if (x == 0)
                return 1;
            else
                return x * Factorial(--x);
        }
        static int Sum (int x)
        {
            if (x == 0)
                return 0;
            else
                return x + Sum(--x);
        }
        static int Fibonachi(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            else
                return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
    }
}
