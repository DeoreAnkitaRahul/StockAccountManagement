namespace StockAccountManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Stock Account Management");
            string path = "C:\\Users\\Rahul\\source\\repos\\StockAccountManagement\\StockAccountManagement\\Stock.json";

            FetchStock fetchStock = new FetchStock();

            StockDetails data = fetchStock.Read(path);

            Console.WriteLine("\nSTOCK VALUE: ");

            for (int i = 0; i < data.stocks.Count; i++)
            {
                Console.WriteLine("\n" + data.stocks[i].StockName);
                Console.WriteLine("shares: " + data.stocks[i].Shares);
                Console.WriteLine("price: " + data.stocks[i].Price);

                int TotalValue = data.stocks[i].Shares * data.stocks[i].Price;
                Console.WriteLine("\nThe Total Value of {0} for {1} shares is: {2} ", data.stocks[i].StockName, data.stocks[i].Shares, TotalValue);
                Console.WriteLine("-------------------------------");
            }
        }
    }
    }
