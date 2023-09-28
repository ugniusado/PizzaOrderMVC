using Microsoft.AspNetCore.Mvc;
using PizzaOrder.Models;

namespace PizzaOrder.Controllers
{
    public class PizzaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CalculateCost(string size, string[] toppings, string otherToppings)
        {
            string allToppings = string.Join(", ", toppings);

            if (!string.IsNullOrEmpty(otherToppings))
            {
                allToppings += ", " + otherToppings;
            }

            var pizza = new Pizza { Size = size, Toppings = allToppings };
            pizza.CalculateCost();
            ViewBag.Cost = pizza.Cost;
            TempData["Toppings"] = allToppings;
            return View();
        }

    }
}
