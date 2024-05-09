using System;
namespace EventWithDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock("Amazon");
            stock.Price = 100;
            stock.OnPriceChanged += Stock_OnPriceChanged;

            stock.ChangePriceBy(-0.02m);
            stock.ChangePriceBy(0.05m);
            stock.ChangePriceBy(0.00m);
            Console.ReadKey();
        }

        private static void Stock_OnPriceChanged(Stock stock, decimal oldPrice)
        {
            if (oldPrice < stock.Price)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{stock.Name}  ${oldPrice} to ${stock.Price}");
            }
            else if (oldPrice > stock.Price)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{stock.Name}  ${oldPrice} to ${stock.Price}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"{stock.Name}  ${oldPrice} to ${stock.Price}");
            }
        }
        
    }
   
}



