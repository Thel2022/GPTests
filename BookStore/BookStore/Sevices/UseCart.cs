using BookStore.Interfaces;
using BookStore.Models;

namespace BookStore.Sevices
{
    public class UseCart : IUseCart
    {
        private readonly BookStoreDbContext _dbcontext;
        public UseCart(BookStoreDbContext _content)
        {
            _dbcontext = _content;
        }
        
    }
}
