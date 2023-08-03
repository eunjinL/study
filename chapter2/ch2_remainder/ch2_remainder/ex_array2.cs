using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 사각형 배열 
namespace ch2_remainder
{
    class ex_array2
    {
        static void Main()
        {
            int[,] matrix = new int[3, 3];  // 2차원 배열 선언 

            // 초기화 하는 방법 1 (for 문으로)
            // GetLength 메서드 : 지정된 차원의 길이를 돌려줌 (첫 차원은 0)

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = i * 3 + j;

            PrintMatrix(matrix);

            // 초기화 하는 방법 2

            int[,] matrix2 = new int[,]
            {
                {0,1,2},
                {3,4,5},
                {6,7,8}
            };

            PrintMatrix(matrix2);
        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

}
