using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Models
{
    public class Store : IStore
    {
        private readonly BookStoreDBContext _content;

        public Store (BookStoreDBContext _content)
        {
            this._content = _content;
        }
        public IEnumerable<Book> Books => _content.BooksDB;
        public Book GetAll(Guid id) => _content.BooksDB.FirstOrDefault(p => p.Id == id);


    }
}
