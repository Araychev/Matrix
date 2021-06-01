using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsCols = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = rowsCols[0];
            int cols = rowsCols[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] colValue = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = colValue[col];
                }
            }

            while (true)
            {
                string[] tokens = Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "END")
                {
                    break;
                }

                if (tokens.Length == 5 && 
                    tokens[0] == "swap" &&
                    int.Parse(tokens[1]) < rows &&
                    int.Parse(tokens[2])<cols)
                {
                    int firstRow = int.Parse(tokens[1]);
                    int firstCol = int.Parse(tokens[2]);
                    int secondRow = int.Parse(tokens[3]);
                    int secondCol = int.Parse(tokens[4]);

                    string temp = matrix[firstRow, firstCol];
                    matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                    matrix[secondRow, secondCol] = temp;
                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine($"Invalid input!");
                }
            }
        }

        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

    }

}
