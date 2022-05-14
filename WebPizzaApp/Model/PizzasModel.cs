namespace WebPizzaApp.Model
{
    public class PizzasModel
    {
		public string ImageTitle { get; set; }


		public string PizzaName { get; set; }


		public float BasePrice { get; set; } = 2;

		public bool Marinara { get; set; }

		public bool Cheese { get; set; }

		public bool Ham { get; set; }

		public bool Chicken { get; set; }

		public bool Beef { get; set; }

		public bool Pepperoni { get; set; }

		public bool Mushroom { get; set; }

		public float FinalPrice { get; set; }
	}
}
