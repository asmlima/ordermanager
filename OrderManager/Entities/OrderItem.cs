using System.Text;

namespace OrderManager.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product ItemProduct { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product itemProduct)
        {
            Quantity = quantity;
            Price = price;
            ItemProduct = itemProduct;
        }

        public double SubTotal()
        {
            double i = Quantity * Price;
            return i;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append($"{ItemProduct.Name}, ");
            sb.Append($"${Price.ToString("F2")}, ");
            sb.Append($"Quantity: {Quantity}, ");
            sb.Append($"Subtotal: ${SubTotal().ToString("F2")}");

            return sb.ToString();
        }
    }
}
