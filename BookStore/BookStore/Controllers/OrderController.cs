﻿using BookStore.Interfaces;
using BookStore.Models;
using BookStore.Sevices;
using BookStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace BookStore.Controllers
{
    public class OrderController : Controller
    {
        private readonly Cart _cart;
        private readonly IOrderProcessing _orderProc;
        private bool valid;     

        private Order GetData(Order order)
        {
            _cart.BooksInCart = _cart.BooksInThisCart(); 

            if (ModelState.IsValid)
            {
                _orderProc.CreateOrder(order);  
                valid = true;
            }
            return order;
        }

        public OrderController(Cart cart, IOrderProcessing orderProc)
        {
            _cart = cart;
            _orderProc = orderProc;
            valid = false;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var viewModel = GetData(order);
            if (valid) return RedirectToAction("Done");  
            return View(viewModel);
        }

        public IActionResult Done()   
        {
            return View();
        }

    }
}
