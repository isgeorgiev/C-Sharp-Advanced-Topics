using System;
using System.Collections.Generic;
using System.Linq;
class JoinLists
{
    static void Main()
    {
        Console.WriteLine("Enter first list of integers on a line, separated by a space:");
        List<string> firstList = new List<string>(Console.ReadLine().Split(new char[] { ' ' }, 
            StringSplitOptions.RemoveEmptyEntries));
        Console.WriteLine("Enter second list of integers on a line, separated by a space:");
        List<string> secondList = new List<string>(Console.ReadLine().Split(new char[] { ' ' }, 
            StringSplitOptions.RemoveEmptyEntries));
        firstList.AddRange(secondList);
        List<int> numbersList = new List<int>();
        for (int i = 0; i < firstList.Count; i++)
        {
            int n;
            bool nParse = int.TryParse(firstList[i], out n);
            if (!nParse)
            {
                Console.WriteLine("invalid input");
                return;
            }
            numbersList.Add(n);
        }
        numbersList = numbersList.Distinct().ToList();
        numbersList.Sort();
        Console.WriteLine("Output:\n" + string.Join(" ", numbersList));
    }
}