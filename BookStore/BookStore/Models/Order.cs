using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Order
    {
        [Display(Name = "Введите имя")] 
        [StringLength(40, MinimumLength = 2)]
        [Required(ErrorMessage = "Длина имени не менее 2-ух символов")]
        public string ClientName { get; set; }

        [Display(Name = "Введите адрес электронной почты")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50, MinimumLength = 3)]
        [Required(ErrorMessage = "Длина адреса не менее 3-ух символов")]
        public string Email { get; set; }
    }
}
