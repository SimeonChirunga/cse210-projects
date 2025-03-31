
 public class Order
    {
        private List<Product> products;
        private Customer customer;
        private const decimal USA_SHIPPING_COST = 5.00m;
        private const decimal INTERNATIONAL_SHIPPING_COST = 35.00m;

        public Order(Customer customer)
        {
            this.customer = customer;
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public decimal GetTotalCost()
        {
            decimal totalCost = 0;
            foreach (Product product in products)
            {
                totalCost += product.GetTotalCost();
            }
            if (customer.LivesInUSA())
            {
                totalCost += USA_SHIPPING_COST;
            }
            else
            {
                totalCost += INTERNATIONAL_SHIPPING_COST;
            }
            return totalCost;
        }

        public string GetPackingLabel()
        {
            string packingLabel = "";
            foreach (Product product in products)
            {
                packingLabel += $"{product.GetName()} ({product.GetProductId()})\n";
            }
            return packingLabel;
        }

        public string GetShippingLabel()
        {
            return customer.GetName() + "\n" + customer.GetAddress().GetFullAddress();
        }
    }