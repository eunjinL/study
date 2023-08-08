using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    class type
    {
		static void Main()
		{
			Point p = new Point();
			Console.WriteLine(p.GetType().Name);             // Point
			Console.WriteLine(typeof(Point).Name);          // Point
			Console.WriteLine(p.GetType() == typeof(Point)); // True
			Console.WriteLine(p.X.GetType().Name);           // Int32
			Console.WriteLine(p.Y.GetType().FullName);       // System.Int32
		}

		public class Point { public int X, Y; }
	}
}
