namespace P04.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            string command;
            while ((command = Console.ReadLine()) != "Revision")
            {
                string[] tokens = command.Split(", ");
                string shopName = tokens[0];
                string productName = tokens[1];
                double price = double.Parse(tokens[2]);

                if (!shops.ContainsKey(shopName))
                {
                    shops[shopName] = new Dictionary<string, double>();
                }

                if (!shops[shopName].ContainsKey(productName))
                {
                    shops[shopName].Add(productName, 0);
                }

                shops[shopName][productName] = price;
            }

            foreach (var (shop, products) in shops)
            {
                Console.WriteLine($"{shop}->");

                foreach (var (product, price )in products)
                {
                    Console.WriteLine($"Product: {product}, Price: {price}");
                }
            }
        }
    }
}