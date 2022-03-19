using System;
using System.Collections.Generic;

namespace Prak4
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
