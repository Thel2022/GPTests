using BookStore.Interfaces;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Sevices
{
    public class StoreBooks : IStoreBooks
    {
        private readonly BookStoreDBContext _dbcontext;

        public StoreBooks(BookStoreDBContext _content)
        {
            _dbcontext = _content;
        }
        public IEnumerable<Book> Books => _dbcontext.BooksDB;
        public Book GetAll(Guid id) => _dbcontext.BooksDB.FirstOrDefault(p => p.Id == id);


    }
}
