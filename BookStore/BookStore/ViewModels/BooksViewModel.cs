using System.Collections.Generic;
using System;
using BookStore.Models;

namespace BookStore.ViewModels
{
    public class BooksViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public BooksViewModel(IEnumerable<Book> books)
        {
            Books = books;
        }

    }
}
