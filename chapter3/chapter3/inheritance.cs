using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    class inheritance
    {
        public class Asset
        {
            public string Name;
        }

        public class Stock : Asset   
        {
            public long SharesOwned;
        }

        public class House : Asset  
        {
            public decimal Mortgage;
        }

        static void Main()
        {
            Stock msft = new Stock { Name = "MSFT", SharesOwned = 1000 };

            Console.WriteLine(msft.Name);         // MSFT
            Console.WriteLine(msft.SharesOwned);  // 1000

            House mansion = new House { Name = "Mansion", Mortgage = 250000 };

            Console.WriteLine(mansion.Name);      // Mansion
            Console.WriteLine(mansion.Mortgage);  // 250000
        }
    }
}
