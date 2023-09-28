namespace PizzaOrder.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int PizzaId { get; set; }
        public string Toppings { get; set; }
        public decimal TotalCost { get; set; }
        public Pizza Pizza { get; set; }
        public void SaveOrder()
        {
        }
    }

}
