using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class CountLetters
{
    static void Main()
    {
        Console.WriteLine("Enter list of letters (case-insensitive) on a line, separated by a space:");
        string input = string.Join("", Console.ReadLine().ToLower().Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries));
        List<char> uniqueLetters = input.Distinct().OrderBy(x => x).ToList();
        if (!Regex.IsMatch(input, @"^[a-z ]+$"))
        {
            Console.WriteLine("The list must contain only letters or no letters entered.");
            return;
        }
        foreach (char c in uniqueLetters)
        {
            Console.WriteLine("{0} -> {1}", c, input.Count(x => x == c));
        }
    }
}
