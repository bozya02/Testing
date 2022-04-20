//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prak4.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int Id { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<int> BuyerId { get; set; }
        public Nullable<int> DeliveryTypeId { get; set; }
        public string Address { get; set; }
        public Nullable<int> PaymentId { get; set; }
    
        public virtual Buyer Buyer { get; set; }
        public virtual DeliveryType DeliveryType { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual Product Product { get; set; }
    }
}
