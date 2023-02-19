using BookStore.Models;
using BookStore.Sevices;
using System;
using System.Collections.Generic;

namespace BookStore.Interfaces
{
    public interface ICart
    {
        string CartId { get; set; }
        IEnumerable<OrderedBooksInCart> BooksInCart { get; set; }
        Cart GetCart(IServiceProvider services);
        void AddToCart(Book book);
        void DeleteFromCart(Guid id);
        IEnumerable<OrderedBooksInCart> BooksInThisCart();
    }
}
