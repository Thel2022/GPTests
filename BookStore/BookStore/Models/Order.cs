using System;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Order
    {
        [Display(Name = "Введите имя")] 
        [StringLength(40, ErrorMessage = "Длина имени не менее 2-ух символов", MinimumLength = 1)]
        public string ClientName { get; set; }

        [Display(Name = "Введите адрес электронной почты")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public Guid Id { get; set; }
        public DateTime OrderTime { get; set; }
    }
}
