using System;
using System.Collections.Generic;
using BookStore.Models;

namespace BookStore.Interfaces
{
    public interface ICatalog
    {
        IEnumerable<Book> Books { get; }
        Book GetAll(Guid id);
    }
}
