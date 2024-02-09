using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace GroceriesManagement
{
    public class GroceriesStore
    {
        public GroceriesStore(int capacity)
        {
            Capacity = capacity;
            Turnover = 0;
            Stall = new List<Product>();
        }

        public int Capacity { get; set; }
        public double Turnover { get; set; }
        public List<Product> Stall { get; set; }

        public void AddProduct(Product product)
        {
            if (Capacity > Stall.Count)
            {
                if (!Stall.Contains(product))
                {
                    Stall.Add(product);
                }
                else
                {
                    return;
                }
            }
        }

        public bool RemoveProduct(string name)
        {
            Product product = Stall.Find(x => x.Name == name);
            if (product != null)
            {
                Stall.Remove(product);
                return true;
            }

            return false;
        }

        public string SellProduct(string name, double quantity)
        {
            if(!Stall.Any(x=>x.Name==name))
            {
                return $"Product not found";
            }
            
            Product product = Stall.First(x => x.Name == name);
            double totalPrice = Math.Round(product.Price * quantity, 2);
            Turnover += totalPrice;
            return $"{product.Name} - {totalPrice:F2}$";
        }

        public string GetMostExpensive() => Stall.OrderByDescending(x => x.Price).FirstOrDefault().ToString();

        public string CashReport()
        {
            return $"Total Turnover: {Turnover:F2}$";
        }

        public string PriceList()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Groceries Price List:");
            foreach (var item in Stall)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }

    }


}
