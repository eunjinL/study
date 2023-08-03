using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_remainder
{
    class ex_array1
    {
		public class Point { public int X, Y; }

		static void Main()
		{
			Point[] a = new Point[1000];

			for (int i = 0; i < a.Length; i++)      // 0부터 999까지 반복 
				a[i] = new Point();                 // 각 원소를 직접 초기화

			Point[] nulls = new Point[1000];
			Console.WriteLine(nulls[0] == null);    // True 값 나옴 
			Console.WriteLine(nulls[0].X);          // null값이라서 오류 발생 
		}
	}
}
