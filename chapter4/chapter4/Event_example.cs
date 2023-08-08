using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter4
{
    class Event_example
	{
		public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);

		public class Stock
		{
			string symbol;
			decimal price;

			public Stock(string symbol) { this.symbol = symbol; }

			public event PriceChangedHandler PriceChanged;

			public decimal Price
			{
				get { return price; }
				set
				{
					if (price == value) return;         // Exit if nothing has changed
					decimal oldPrice = price;
					price = value;
					if (PriceChanged != null)           // If invocation list not empty,
						PriceChanged(oldPrice, price);  // fire event.
				}
			}
		}

		static void Main()
		{
			var stock = new Stock("MSFT");
			stock.PriceChanged += ReportPriceChange;
			stock.Price = 123;
			stock.Price = 456;
		}

		static void ReportPriceChange(decimal oldPrice, decimal newPrice)
		{
			Console.WriteLine("Price changed from " + oldPrice + " to " + newPrice);
		}
	}
}
