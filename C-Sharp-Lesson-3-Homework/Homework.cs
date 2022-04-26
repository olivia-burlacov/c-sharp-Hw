using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_3_Homework
{
    public class Homework
    {
        public void GetCentralElementFromMatrix(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result             |
             * |-------------------|--------------------|
             * | {                 |                    |
             * |  { 1,   3,  5},   |    The central     |
             * |  {-1, 100, 11},   |  element is 100    |
             * |  { 2,  15, 44}    |                    |
             * |  }                |                    |
             * |----------------------------------------|
             * |{                  |                    |
             * | { 1,  6, 21,  8 },| This matrix doesn't|
             * | { 5, -4,  5,  7 },| have a central     |
             * | {77,  5,  0, 74 } |  element           |
             * | }                 |                    |
             * ------------------------------------------
             *    
             */

            int len0 = matrixOfIntegers.GetLength(0);
            int len1 = matrixOfIntegers.GetLength(1);
            if (len0 % 2 == 0 || len1 % 2 == 0)
            {
                Console.WriteLine("This matrix doesn't have a central element");
            }
            else
            {
                int centerValue = matrixOfIntegers[len0 / 2, len1 / 2];
                Console.WriteLine("The centaral element is " + centerValue);
            }

        }
        public void GetSummOfDiagonalsElements(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result              |
             * |-------------------|---------------------|
             * | {                 |                     |
             * |  { 1,   3,  5},   | First diagonal: 145 |
             * |  {-1, 100, 11},   | Second diagonal: 107|
             * |  { 2,  15, 44}    |                     |
             * |  }                |                     |
             * |-----------------------------------------|
             * |{                  |                     |
             * | { 1,  6, 21,  8 },| This matrix doesn't |
             * | { 5, -4,  5,  7 },| have a diagonals    |
             * | {77,  5,  0, 74 } |                     |
             * | }                 |                     |
             * ------------------------------------------
             *    
             */
           
            int len0 = matrixOfIntegers.GetLength(0);
            int len1 = matrixOfIntegers.GetLength(1);
            if (len0 != len1)
            {
                Console.WriteLine("This matrix doesn't have diagonals");
            }
            else
            {
                int firstDiagonalSumm = 0;
                int secondDiagonalSumm = 0;
                for (var i = 0; i < len0; i++)
                {
                    for (var j = 0; j < len1; j++)
                    {
                        if (i == j)
                        {
                            firstDiagonalSumm = firstDiagonalSumm + matrixOfIntegers[i, j];
                        }
                        else if ((i + j) == (len1 - 1))
                        {
                            secondDiagonalSumm = secondDiagonalSumm + matrixOfIntegers[i, j];
                        }

                    }
                }
                Console.WriteLine("First Diagonal Summ is " + firstDiagonalSumm);
                Console.WriteLine("Second Diagonal Summ is " + secondDiagonalSumm);
            }
         }
        public void StarPrinter(int triangleHight)
        {
            /* Write a programm that will print a triagle of stars  with hight = triangleHight
             *  Example: triangleHight = 3;
             *  Result:   *
             *           * *
             *          * * * 
             */
            int i, j, k, count = 0; 
            count = triangleHight - 1;
            for (i = 0; i < triangleHight; i++)
            {
                 
                for (j = 0; j <count; j++)
                {
                    Console.Write(" ");
                }
                count--;
                
                for (k = 0; k <= i ; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        public void SortList(IList<int> listOfNumbers)
        {
            int temp;
            for (int i = 0; i < listOfNumbers.Count - 1; i++)
            {
                for (int j = 0; j < listOfNumbers.Count - i - 1; j++)
                {
                    if (listOfNumbers[j] > listOfNumbers[j + 1])
                    {
                        temp = listOfNumbers[j + 1];
                        listOfNumbers[j + 1] = listOfNumbers[j];
                        listOfNumbers[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted list:");
            foreach (int p in listOfNumbers) { 
                Console.Write(p + " ");
            }
            var newList = listOfNumbers.OrderBy(number => number);
            Console.WriteLine();
            Console.WriteLine("Sorted list asc:");
            foreach (int p in newList)
            {
                Console.Write(p + " ");
            }
        }



        public static void Main(String[] args)
        {
            Homework homework = new Homework();
            IList<int> list = new List<int>() { -5, 8, -7, 0, 44, 121, -7 };
            int[,] matrix = new int[3, 3] {
                { 1,   3,  5},
                { 2, 3, 5},
                {100, 56 , -54} };
            int[,] matrix2 = new int[3, 4] {
                { 1,   3,  5,   6},
                { 2,   3,  5,  78},
                {100, 56 , -54, 6} };
            int[,] matrix3 = new int[4, 4] {
                { 1,   3,  5,   6},
                { 2,   3,  5,  78},
                {100, 56 , -54, 6},
                {10, 6 , -4, 61} };

            homework.GetCentralElementFromMatrix(matrix);
            homework.GetCentralElementFromMatrix(matrix2);
            homework.GetCentralElementFromMatrix(matrix3);
            homework.GetSummOfDiagonalsElements(matrix);
            homework.GetSummOfDiagonalsElements(matrix2);
            homework.StarPrinter(5);
            homework.SortList(list);
        }

    }
}
