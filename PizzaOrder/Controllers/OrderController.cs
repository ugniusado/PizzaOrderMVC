using Microsoft.AspNetCore.Mvc;
using PizzaOrder.Models;

namespace PizzaOrder.Controllers
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Toppings { get; set; }
        public decimal TotalCost { get; set; }
    }
    public class OrderController : Controller
    {
        private static List<Order> orders = new List<Order>();
        private static int lastOrderId = 0;
        public ActionResult Index()
        {
            ViewBag.Orders = orders;
            return View();
        }
        [HttpPost]
        public ActionResult SaveOrder(decimal cost)
        {
            string toppings = TempData["Toppings"] as string;
            var order = new Order { OrderId = ++lastOrderId, Toppings = toppings, TotalCost = cost };
            orders.Add(order);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteOrder(int orderId)
        {
            var orderToRemove = orders.FirstOrDefault(o => o.OrderId == orderId);
            if (orderToRemove != null)
            {
                orders.Remove(orderToRemove);
            }

            return RedirectToAction("Index");
        }

    }
}
