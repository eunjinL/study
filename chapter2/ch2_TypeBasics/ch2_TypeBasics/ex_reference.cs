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

			Point p2 = p1;             // ���� Ÿ�� ���� 

			Console.WriteLine(p1.X);  // 7
			Console.WriteLine(p2.X);  // 7

			p1.X = 9;                  // p1.X�� ���� �ٲٸ� �� �ٲ�

			Console.WriteLine(p1.X);  // 9
			Console.WriteLine(p2.X);  // 9
		}
	}
}
