using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebPizzaApp.Models;


namespace WebPizzaApp.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
           new PizzasModel(){
               ImageTitle="Margerita",
               PizzaName="Margerita",
               BasePrice=2,
               Marinara=true,
               Cheese=true,
               FinalPrice=4},
           new PizzasModel() {ImageTitle = "Bolognese", PizzaName = "Bolognese", BasePrice = 2, Marinara=true, Cheese = true, Beef = true, FinalPrice = 5 },
           new PizzasModel() {ImageTitle = "Hawaiian", PizzaName = "Hawaiian", BasePrice = 2, Marinara=true, Cheese = true, Beef = true, FinalPrice = 5 },
           new PizzasModel() {ImageTitle = "Carbonara", PizzaName = "Carbonara", BasePrice = 2, Marinara=true, Cheese = true, Beef = true, FinalPrice = 5 },
           new PizzasModel() {ImageTitle = "Margerita", PizzaName = "Magerita", BasePrice = 2, Marinara=true, Cheese = true, Beef = true, FinalPrice = 5 },
           new PizzasModel() {ImageTitle = "Mushroom", PizzaName = "Mushroom", BasePrice = 2, Marinara=true, Cheese = true, Beef = true, FinalPrice = 5 },
           new PizzasModel() {ImageTitle = "Pepperoni", PizzaName = "Pepperoni", BasePrice = 2, Marinara=true, Cheese = true, Beef = true, FinalPrice = 5 },
           new PizzasModel() {ImageTitle = "Vegetarian", PizzaName = "Vegetarian", BasePrice = 2, Marinara=true, Cheese = true, Beef = true, FinalPrice = 5 },
           new PizzasModel() {ImageTitle = "Seafood", PizzaName = "Seafood", BasePrice = 2, Marinara=true, Cheese = true, Beef = true, FinalPrice = 5 },
           new PizzasModel() {ImageTitle = "Meatfeast", PizzaName = "MeatFeast", BasePrice = 2, Marinara=true, Cheese = true, Beef = true, FinalPrice = 5 },


        };
        public void OnGet()
        {
        }
    }
}
