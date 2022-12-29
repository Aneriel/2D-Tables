using System;

namespace _2D_Tables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputA = Console.ReadLine().Split(' ');
            int n1 = int.Parse(inputA[0]);
            int m1 = int.Parse(inputA[1]);
            int[,] matrixA = new int[n1, m1];
            string[] rowValuesA = Console.ReadLine().Split(' ');
            int rowIndexA = 0;
            int colIndexA = 0;
            foreach (string value in rowValuesA)
            {
                matrixA[rowIndexA, colIndexA] = int.Parse(value);
                colIndexA++;
                if (colIndexA == m1)
                {
                    rowIndexA++;
                    colIndexA = 0;
                }
            }
            string[] inputB = Console.ReadLine().Split(' ');
            int n2 = int.Parse(inputB[0]);
            int m2 = int.Parse(inputB[1]);
            if (m1 != n2)
            {
                Console.WriteLine("impossible");
            }
            else
            {
                int[,] matrixB = new int[n2, m2];
                string[] rowValuesB = Console.ReadLine().Split(' ');
                int rowIndexB = 0;
                int colIndexB = 0;
                foreach (string value in rowValuesB)
                {
                    matrixB[rowIndexB, colIndexB] = int.Parse(value);
                    colIndexB++;
                    if (colIndexB == m2)
                    {
                        rowIndexB++;
                        colIndexB = 0;
                    }
                }
                int[,] resultMatrix = new int[n1, m2];
                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < m2; j++)
                    {
                        int result = 0;
                        for (int k = 0; k < m1; k++)
                        {
                            result += matrixA[i, k] * matrixB[k, j];
                        }
                        resultMatrix[i, j] = result;
                    }
                }
                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < m2; j++)
                    {
                        Console.Write(resultMatrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}