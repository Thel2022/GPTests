using System.Collections.Generic;

namespace BookStore.Models
{
    public class Cart
    {
        public decimal OrderCost { get; set; }
        public List<OrderingBooksInCart> BooksInCart { get; set; }
    }
}
