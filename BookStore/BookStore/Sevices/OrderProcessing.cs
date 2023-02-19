using BookStore.Interfaces;
using BookStore.Models;
using System;
using System.Collections.Generic;

namespace BookStore.Sevices
{
    public class OrderProcessing : IOrderProcessing
    {
        private readonly BookStoreDbContext _dbcontext;
        private readonly ICart _cart;
        public IEnumerable<Order> Orders => _dbcontext.OrderTb;
        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            _dbcontext.OrderTb.Add(order);
            _dbcontext.SaveChanges();

            var items = _cart.BooksInCart;
            foreach (var item in items)
            {
                var orderContent = new OrderContent
                {
                    BookId = item.Book.Id,
                    OrderId = order.Id,
                    Price = item.Book.Price
                };
                _dbcontext.OrderContentTb.Add(orderContent);
            }

            _dbcontext.OrderedBooksInCartTb.RemoveRange(_dbcontext.OrderedBooksInCartTb);
            _dbcontext.SaveChanges();
        }
    }
}
