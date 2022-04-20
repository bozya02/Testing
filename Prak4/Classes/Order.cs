using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prak4.Classes
{
    public class Order
    {
        [Required]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Не верное количество")]
        [Range(1,10)]
        public int? Сount { get; set; }
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Неверная длина имени")]
        public string BuyerName { get; set; }
        [Required]
        public string PaymentMethod { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage ="Не задан способ доставки")]
        public string DeliveryType { get; set; }
    }
}
