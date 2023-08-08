using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    class enum_ex
    {
        public enum BorderSide { Left, Right, Top, Bottom }

        static void Main()
        {
            BorderSide topSide = BorderSide.Top;
            bool isTop = (topSide == BorderSide.Top);
            Console.WriteLine(isTop);
        }

    }
}
