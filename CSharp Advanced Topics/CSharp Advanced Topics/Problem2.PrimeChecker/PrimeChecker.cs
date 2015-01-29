using System;

    class PrimeChecker
    {
        static void Main()
        {

            Console.Write("n= ");
            long number;
            bool numberParse = long.TryParse(Console.ReadLine(), out number);
            if (numberParse && number >= 0)
            {
                Console.WriteLine(IsPrime(number));
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
        static bool IsPrime(long n)
        {
            if (n == 0 || n == 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }

