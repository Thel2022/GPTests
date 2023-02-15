using BookStore.Interfaces;
using BookStore.Models;

namespace BookStore.Sevices
{
    public class UseCart : IUseCart
    {
        private readonly BookStoreDBContext _dbcontext;
        public UseCart(BookStoreDBContext _content)
        {
            _dbcontext = _content;
        }
        
    }
}
