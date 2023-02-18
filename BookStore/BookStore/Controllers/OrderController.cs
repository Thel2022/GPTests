using BookStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult OrderFirstStep()
        {
            var viewModel = new OrderViewModel();
            return View(viewModel);
        }
    }
}
