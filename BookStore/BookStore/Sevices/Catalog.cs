using BookStore.Interfaces;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Sevices
{
    public class Catalog : ICatalog
    {
        private readonly BookStoreDbContext _dbcontext;

        public Catalog(BookStoreDbContext _context)
        {
            _dbcontext = _context;
        }
        public IEnumerable<Book> Books => _dbcontext.BooksTb;
        public Book GetAll(Guid id) => _dbcontext.BooksTb.FirstOrDefault(p => p.Id == id);

    }
}
