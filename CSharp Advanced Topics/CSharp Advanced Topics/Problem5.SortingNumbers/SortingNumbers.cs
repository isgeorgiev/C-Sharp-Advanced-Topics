﻿using System;
using System.Collections.Generic;
using System.Linq;
class SortingNumbers
{
    static void Main()
    {
        Console.Write("Numbers to read: ");
        int n;
        bool nParse = int.TryParse(Console.ReadLine(), out n);
        List<int> numbers = new List<int>();
        if (!nParse)
        {
            Console.WriteLine("invalid input");
            return;
        }
        Console.WriteLine("Enter {0} integer number/s", n);
        for (int i = 1; i <= n; i++)
        {
            Console.Write("number[{0}]: ", i);
            int number;
            bool numberParse = int.TryParse(Console.ReadLine(), out number);
            if (numberParse)
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input.Try again.");
                i--;
            }
        }
        numbers.Sort();
        Console.WriteLine("\nOutput:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}