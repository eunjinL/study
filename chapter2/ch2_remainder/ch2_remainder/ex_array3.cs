using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_remainder
{
    class ex_array3
    {
        static void Main()
        {
            int[][] matrix = new int[3][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[3];
                for (int j = 0; j < matrix[i].Length; j++)
                    matrix[i][j] = i * 3 + j;
            }

            PrintMatrix(matrix);

            int[][] matrix2 = new int[][]
            {
                new int[] {0,1,2},
                new int[] {3,4,5},
                new int[] {6,7,8,9}
            };

            PrintMatrix(matrix2);
        }

        static void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
