using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3] {
                { 1,   3,  5},
                { 2, 3, 5},
                {100, 56 , 4} };
            int[,] matrix2 = new int[3, 4] {
                { 1,   3,  5,   6},
                { 2,   3,  5,  78},
                {100, 56 , -54, 6} };
            int[,] matrix3 = new int[4, 4] {
                { 1,   3,  5,   6},
                { 2,   3,  5,  78},
                {100, 56 , -54, 6},
                {10, 6 , -4, 61} };

            CustomMatrix.GetSummOfDiagonalsElements(matrix);
            CustomMatrix.GetSummOfDiagonalsElements(matrix2);
            CustomMatrix.GetSummOfDiagonalsElements(matrix3);

        }
    }
}
