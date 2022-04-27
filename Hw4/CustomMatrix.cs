using System;

namespace Hw4
{   //Defining a class
    class CustomMatrix
    {
    //Fields
        private int rows;
        private int col;
        private int[,] matrix;

    //Constructor
        public CustomMatrix(int[,] matrix)
        {
            rows = matrix.GetLength(0);
            col = matrix.GetLength(1);
            this.matrix = matrix;
        }

    //Defining method to print the sum of both diagonals
        public void GetSummOfDiagonalsElements()
        {
            PrintMatrix();
            if (HasMatrixDiagonals())
            {
                int sumD1 = SumFirstDiagonal();
                int sumD2 = SumSecondDiagonal();
            }
        }

     //Defining method to switch the matrixes
        public void setMatrix(int[,] matrix)
        {
            rows = matrix.GetLength(0);
            col = matrix.GetLength(1);
            this.matrix = matrix;
        }

    //Defining method to check if the matrix has diagonals
        private bool HasMatrixDiagonals()
        {
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

    //Defining method to sum the first diagonal
        private int SumFirstDiagonal()
        {
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

    //Defining method to sum the second diagonal
        private int SumSecondDiagonal()
        {
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

     //Defining method to print the matrix (as a proper matrix)
        private void PrintMatrix()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            for (var i = 0; i < matrix.GetLength(0); i++)
            {

                Console.WriteLine();
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }

            Console.WriteLine();
        }





    //Defining a method to sum 2 digits
        public void AddDigits(int a, int b)
        {
            Console.WriteLine(a + b);
        }

    //Defining same method with different parameters (method OVERLOADING)
        public void AddDigits(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
    }
}
