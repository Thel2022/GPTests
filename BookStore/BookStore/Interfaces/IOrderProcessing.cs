using BookStore.Models;
using System.Collections.Generic;

namespace BookStore.Interfaces
{
    public interface IOrderProcessing
    {
        IEnumerable<Order> Orders { get; }
        void CreateOrder(Order order);
    }
}
