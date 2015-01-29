using System;
using System.Collections.Generic;
using System.Linq;
class MatrixOfPalindromes
{
    static void Main()
    {
        Console.WriteLine("Enter matrix dimensions");
        Console.Write("height: ");
        int height;
        bool heightParse = int.TryParse(Console.ReadLine(), out height);
        Console.Write("width: ");
        int width;
        bool widthParse = int.TryParse(Console.ReadLine(), out width);
        if (!heightParse || !widthParse || height < 1 || width < 1)
        {
            Console.WriteLine("invalid input");
            return;
        }
        string[,] polindromes = new string[height, width];
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                polindromes[i, j] = "" + (char)('a' + i) + (char)('a' + i + j) + (char)('a' + i);
                Console.Write(polindromes[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}