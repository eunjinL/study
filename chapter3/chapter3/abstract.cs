using System;

namespace chapter3
{
    class Program // 클래스 이름을 Program으로 변경
    {
        static void Main(string[] args) // args 추가
        {
            var stock = new Stock { SharesOwned = 200, CurrentPrice = 123.45M };
            Console.WriteLine(stock.NetValue);
        }

        public abstract class Asset // Note abstract keyword
        {
            public abstract decimal NetValue { get; } // Note empty implementation
        }

        public class Stock : Asset
        {
            public long SharesOwned;
            public decimal CurrentPrice;

            // Override like a virtual method.
            public override decimal NetValue => CurrentPrice * SharesOwned;
        }
    }
}
