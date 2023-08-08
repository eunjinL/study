using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    class EnumConvert
    {
        public enum BorderSide { Left, Right, Top, Bottom }

        public enum HorizontalAlignment
        {
            Left = BorderSide.Left,
            Right = BorderSide.Right,
            Center
        }

        static void Main()
        {
            int i = (int)BorderSide.Left;
            Console.WriteLine($"i: {i}");

            BorderSide side = (BorderSide)i;
            Console.WriteLine($"side: {side}");

            bool leftOrRight = (int)side <= 2;
            Console.WriteLine($"leftOrRight: {leftOrRight}");

            HorizontalAlignment h = (HorizontalAlignment)BorderSide.Right;
            Console.WriteLine($"h: {h}");

            BorderSide b = 0;
            Console.WriteLine($"b: {b}");
        }
    }
}
