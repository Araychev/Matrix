using System;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[][] matrix = new char[n][];

            for (int row = 0; row < n; row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray();
            }
            int removedKnites = 0;
            while (true)
            {
                int knightRow = -1;
                int knightCol = -1;
                int maxAttaced = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (matrix[row][col] == 'K')
                        {
                            int tempAttacks = CauntAttaks(matrix, row, col);
                            if (tempAttacks > maxAttaced)
                            {
                                maxAttaced = tempAttacks;
                                knightRow = row;
                                knightCol = col;
                            }
                        }
                    }
                }

                if (maxAttaced>0)
                {
                    matrix[knightRow][knightCol] = '0';
                    removedKnites++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(removedKnites);
        }

        static int CauntAttaks(char[][] matrix, int row, int col)
        {
            int attack = 0;
            if (IsInMatrix(row + 1, col - 2, matrix.Length) && matrix[row + 1][col - 2] == 'K')
            {
                attack++;
            }
            if (IsInMatrix(row - 1, col - 2, matrix.Length) && matrix[row - 1][col - 2] == 'K')
            {
                attack++;
            }
            if (IsInMatrix(row - 1, col + 2, matrix.Length) && matrix[row - 1][col + 2] == 'K')
            {
                attack++;
            }
            if (IsInMatrix(row + 1, col + 2, matrix.Length) && matrix[row + 1][col + 2] == 'K')
            {
                attack++;
            }
            if (IsInMatrix(row - 2, col - 2, matrix.Length) && matrix[row - 2][col - 1] == 'K')
            {
                attack++;
            }
            if (IsInMatrix(row - 2, col + 1, matrix.Length) && matrix[row - 2][col + 1] == 'K')
            {
                attack++;
            }
            if (IsInMatrix(row + 2, col - 1, matrix.Length) && matrix[row + 2][col - 1] == 'K')
            {
                attack++;
            }
            if (IsInMatrix(row + 2, col + 1, matrix.Length) && matrix[row + 2][col + 1] == 'K')
            {
                attack++;
            }

            return attack;
        }

        private static bool IsInMatrix(int row, int col, int lengh)
        {
            return row >= 0 && row < lengh && col >= 0 && col < lengh;
        }
    }
}
