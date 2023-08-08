using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    class @struct
    {
		public struct Point
		{
			public int X, Y;
			public Point(int x, int y) { X = x; Y = y; }
			// The parameterless constructor is implicit.
		}

		static void Main()
		{
			Point p1 = new Point();       // p1.x and p1.y will be 0
			Console.WriteLine(p1.X);
			Console.WriteLine(p1.Y);

			Point p2 = new Point(1, 1);   // p1.x and p1.y will be 1
			Console.WriteLine(p2.X);
			Console.WriteLine(p2.Y);
		}
	}
}
