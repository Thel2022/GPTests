using System;
using System.Collections.Generic;

namespace BookStore.Models
{
    public interface IStore
    {
        IEnumerable<Book> Books { get; }
        Book GetAll(Guid id);
    }
}
