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
			Point p = null;
			Console.WriteLine(p == null);   // 참조 변수 p의 값을 null로 배정 

			// 처리되지 않은 예외 (참조가 아무 객체도 가리키지 않기 때문)
			Console.WriteLine(p.x);
		}
	}
}
