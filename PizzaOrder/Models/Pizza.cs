namespace PizzaOrder.Models
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        public string Size { get; set; }
        public string Toppings { get; set; }
        public decimal Cost { get; set; }
        public void CalculateCost()
        {
            switch (Size)
            {
                case "small":
                    Cost = 8;
                    break;
                case "medium":
                    Cost = 10;
                    break;
                case "large":
                    Cost = 12;
                    break;
            }

            int numberOfToppings = Toppings.Split(',').Length;
            Cost += numberOfToppings;

            if (numberOfToppings > 3)
            {
                Cost *= 0.9m; // apply 10% discount
            }
        }

    }
}
