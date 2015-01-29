using System;
using System.Numerics;

    class FibonacciNumbers
    {
        static void Main()
        {

            Console.Write("n= ");
            int n;
            bool numberParse = int.TryParse(Console.ReadLine(), out n);
            if (numberParse && n >= 0)
            {
                Console.WriteLine(Fib(n));
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
        static BigInteger Fib(int n)
        {
            BigInteger x1 = 0;
            BigInteger x2 = 1;
            for (int i = 0; i < n; i++)
            {
                x2 = x2 + x1;
                x1 = x2 - x1;
            }
            return x2;
        }
    }

