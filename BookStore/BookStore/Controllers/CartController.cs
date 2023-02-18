using BookStore.Interfaces;
using BookStore.Sevices;
using BookStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace BookStore.Controllers
{
    public class CartController : Controller
    {
        private readonly ICatalog _catalog;
        private readonly Cart _cart;

        public CartController(ICatalog catalog, Cart cart)
        {
            _catalog = catalog;
            _cart = cart;
        }

        [HttpGet]
        public ViewResult Cart()
        {
            var items = _cart.BooksInThisCart();
            _cart.BooksInCart = items;

            var obj = new CartViewModel { cart = _cart };

            return View(obj);
        }

        public RedirectToActionResult AddToCart(Guid id)
        {
            var item = _catalog.Books.FirstOrDefault(i => i.Id == id);
            if (item != null && item.InStock > 0)
            {
                _cart.AddToCart(item);
            }
 
            return RedirectToAction("Cart");
        }

        public RedirectToActionResult DeleteFromCart(Guid id)
        {
            var item = _catalog.Books.FirstOrDefault(i => i.Id == id);
            _cart.DeleteFromCart(id);
            return RedirectToAction("Cart");
        }

    }
}


