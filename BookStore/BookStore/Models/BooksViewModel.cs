using System.Collections.Generic;
using System;

namespace BookStore.Models
{
    public class BooksViewModel
    {
        public IEnumerable<Book> IStore { get; set; }   // // repository of entity "Game" instances
        public BooksViewModel(IEnumerable<Book> books)
        {
            IStore = books;
           
        }
              
    }
}
