using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowCol = ReadArrayFromConsole();

            int rows = rowCol[0];
            int cols = rowCol[1];

            int[,] matrix = FillMatrix(rows, cols);
            PrintCollSum(matrix);
        }

        static void PrintCollSum(int[,] matrix)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);

            }
        }

        static int[,] FillMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            return matrix;
        }

        static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
        }
    }
}
