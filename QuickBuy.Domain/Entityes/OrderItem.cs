using System.Collections.Generic;

namespace QuickBuy.Domain.Entityes
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int ProductId{ get; set; }
        public int Quantity { get; set; }

    }
}
