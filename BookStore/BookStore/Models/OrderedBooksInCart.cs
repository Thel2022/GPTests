using System;

namespace BookStore.Models
{
    public class OrderedBooksInCart
    {
        public Guid Id { get; set; }
        public Book Book { get; set; }
        public string CartId { get; set; }
        public decimal OrderCost { get; set; }
    }
}
