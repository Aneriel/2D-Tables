using System;

namespace _2D_Tables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split(" ");
            int wiersze = int.Parse(size[0]);
            int kolumny = int.Parse(size[1]);
            int[,] macierz = new int[wiersze, kolumny];
            for (int i = 0; i < wiersze; i++)
            {
                string[] rowNums = Console.ReadLine().Split(" ");
                for (int j = 0; j < kolumny; j++)
                {
                    macierz[i, j] = int.Parse(rowNums[j]);
                }
            }
            for (int i = 0; i < kolumny; i++)
            {
                for (int j = 0; j < wiersze; j++)
                {
                    Console.Write("{0} ", macierz[j, i]);
                }
                Console.WriteLine();
            }
        }
    }
}
