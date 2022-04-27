using System;

namespace Hw4
{
    class CustomMatrix
    {
        public static void GetSummOfDiagonalsElements(int[,] matrix)
        {
            PrintMatrix(matrix);
            if (HasMatrixDiagonals(matrix))
            {
                int sumD1 = SumFirstDiagonal(matrix);
                int sumD2 = SumSecondDiagonal(matrix);
            }
        }




        public static bool HasMatrixDiagonals(int[,] matrix)
        {

            int rows = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            if (rows != col)
            {
                Console.WriteLine("This matrix doesn't have diagonals");
                return false;
            }
            else
            {
                Console.WriteLine("This matrix has diagonals");
                return true;
            }
        }
        public static int SumFirstDiagonal(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            int firstDiagonalSumm = 0;
            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < col; j++)
                {
                    if (i == j)
                    {
                        firstDiagonalSumm = firstDiagonalSumm + matrix[i, j];
                    }
                }
            }
            Console.WriteLine("First Diagonal Summ is " + firstDiagonalSumm);
            return firstDiagonalSumm;
        }
        public static int SumSecondDiagonal(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            int secondDiagonalSumm = 0;

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < col; j++)
                {
                    if ((i + j) == (col - 1))
                    {
                        secondDiagonalSumm = secondDiagonalSumm + matrix[i, j];
                    }
                }
            }
            Console.WriteLine("Second Diagonal Summ is " + secondDiagonalSumm);
            return secondDiagonalSumm;
        }
        public static void PrintMatrix(int[,] matrix)
        {


            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            for (var i=0; i<matrix.GetLength(0); i++)
            {

                Console.WriteLine();
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
