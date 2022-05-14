using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebPizzaApp.Models;

namespace WebPizzaApp.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }


        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.Marinara) PizzaPrice += 1;
            if (Pizza.Chicken) PizzaPrice += 8;
            if (Pizza.Pepperoni) PizzaPrice += 3;
            if (Pizza.Mushroom) PizzaPrice += 3;
            if (Pizza.Beef) PizzaPrice += 8;
            if (Pizza.Ham) PizzaPrice += 4;
            if (Pizza.Cheese) PizzaPrice += 3;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice });
        }
    }
}