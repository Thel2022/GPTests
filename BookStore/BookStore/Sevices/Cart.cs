using BookStore.Interfaces;
using BookStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Sevices
{
    public class Cart : ICart
    {
        private readonly BookStoreDbContext _dbcontext;
        public string CartId { get; set; }
        public IEnumerable<OrderedBooksInCart> BooksInCart { get; set; }
        public Cart(BookStoreDbContext _content)
        {
            _dbcontext = _content;
        }
        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<BookStoreDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);
            return new Cart(context) { CartId = cartId };
        }
        public void AddToCart(Book book)
        {

            _dbcontext.OrderedBooksInCartTb.Add(new OrderedBooksInCart
            {
                CartId = CartId,
                Book = book,
                OrderCost = book.Price
            });
            book.InStock--;
            _dbcontext.SaveChanges();
        }
        public void DeleteFromCart(Guid id)
        {
            var item = _dbcontext.OrderedBooksInCartTb.Where(c => c.Id == id).First();
            item.Book.InStock++;
            var itemToDelete = _dbcontext.OrderedBooksInCartTb.Where(c => c.Id == id).First();
            _dbcontext.OrderedBooksInCartTb.Remove(itemToDelete);
            _dbcontext.SaveChanges();
        }
        public IEnumerable<OrderedBooksInCart> BooksInThisCart()
        {
            return _dbcontext.OrderedBooksInCartTb.Where(c => c.CartId == CartId).Include(s => s.Book).ToList();
        }
    }
}
