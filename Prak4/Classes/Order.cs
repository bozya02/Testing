using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prak4.Classes
{
    public class Order
    {
        public int Id { get; set; }
        public int BuyerId { get; set; }
        public int ProductId { get; set; }
        public int count { get; set; }
        public int DeliveryTypeId { get; set; }
    }
}
