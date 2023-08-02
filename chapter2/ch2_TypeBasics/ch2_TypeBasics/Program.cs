using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_TypeBasics
{
    class Program
    {
        public struct Point
        {
            public int x, y;
        }
        static void Main()
        {
            Point p1 = new Point();
            p1.x = 7;

            Point p2 = p1;             

            Console.WriteLine(p1.x);  // 7
            Console.WriteLine(p2.x);  // 7

            p1.x = 9;                  // p1의 x값 변경

            Console.WriteLine(p1.x);  // 9
            Console.WriteLine(p2.x);  // 7
        }
    }
}
