﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using BookStore.Models;
using BookStore.Interfaces;
using BookStore.ViewModels;

namespace BookStore.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ICatalog _store;

        private BooksViewModel GetData()
        {

            IEnumerable<Book> books = null;

            books = _store.Books;

            return new BooksViewModel(books);
        }
        public CatalogController(ICatalog store)
        {
            _store = store;
        }

        [Route("Home/Catalog")]
        [HttpGet]
        public ViewResult Catalog()
        {
            var viewModel = GetData();
            return View(viewModel);
        }
    }
}
