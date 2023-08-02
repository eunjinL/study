using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_TypeBasics
{
	class Program
	{
		public class Point
		{
			public int x, y;
		}
		static void Main()
		{
			Point p1 = new Point();
			p1.X = 7;

			Point p2 = p1;             // 참조 타입 복사 

			Console.WriteLine(p1.X);  // 7
			Console.WriteLine(p2.X);  // 7

			p1.X = 9;                  // p1.X의 값을 바꾸면 다 바뀜

			Console.WriteLine(p1.X);  // 9
			Console.WriteLine(p2.X);  // 9
		}
	}
}
