using System;

namespace BookStore.Models
{
    public class OrderContent
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid BookId { get; set; }
        public decimal Price { get; set; }
        public Book book { get; set; }
        public virtual Order Order { get; set; }
    }
}
