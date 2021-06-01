using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int nRow = rowCol[0];
            int nCol = rowCol[1];

            var matrix = new char[nRow, nCol];

            for (int row = 0; row < nRow; row++)
            {
                char[] colValue = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < nCol; col++)
                {
                    matrix[row, col] = colValue[col];
                }
            }

            int count = 0;
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] &&
                        matrix[row, col] == matrix[row + 1, col] &&
                        matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);

        }
    }
}
