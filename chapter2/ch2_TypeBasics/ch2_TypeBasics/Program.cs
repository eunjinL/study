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
			p1.x= 7;

			Point p2 = p1;             // 참조로 복사 

			Console.WriteLine(p1.x);  // 7
			Console.WriteLine(p2.x);  // 7

			p1.x = 9;                  // P1의 x만 변경

			Console.WriteLine(p1.x);  // 9
			Console.WriteLine(p2.x);  // 9
		}
	}
}
