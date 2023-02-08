using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IStore _store;
        BooksViewModel viewModel;
        public CatalogController(IStore store)
        {
            _store = store;
        }

        private IEnumerable<Book> GetData()
        {
            
            IEnumerable<Book> books = null;
                    
            books = _store.Books;
 
            viewModel = new BooksViewModel(books);
               
            return books;
        }

        [Route("Home/Catalog")]   // attribute routing
        [HttpGet]
        public ViewResult Catalog()
        {
            GetData();
            return View(viewModel);
        }
    }
}
