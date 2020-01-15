using QuickBuy.Domain.ValueObject;
using System;
using System.Collections.Generic;

namespace QuickBuy.Domain.Entityes
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }

        public DateTime PreviousOrderDate { get; set; }
        public string CEP { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string CompleteAddress { get; set; }
        public int AddressNumber { get; set; }

        public int FormPaymentId { get; set; }

        public FormPayment FormPayment { get; set; }


    }
}
