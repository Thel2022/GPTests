using BookStore.Interfaces;
using BookStore.Models;
using BookStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BookStore.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderProcessing _orderProc;

        public OrderController(IOrderProcessing orderProc)
        {
            _orderProc = orderProc;

        }
        public Order GetData(Order order)
        {
            if (ModelState.IsValid)
            {
                _orderProc.CreateOrder(order);
            }
            return order;
        }

        public IActionResult OrderFirstStep()
        {
            var viewModel = new OrderViewModel();
            return View(viewModel);
        }

        public IActionResult OrderSecondStep() 
        {
            return View();
        }
    }
}
