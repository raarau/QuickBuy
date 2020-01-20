using QuickBuy.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entityes
{
    public class Order : Entity
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

        public override void Validate()
        {

            ClearMessageValidation();
            
            if (!OrderItems.Any())
            {
                AddCritical("Crítica: Item pedido, não pode ficar vazio.");
                //MessageValidation.Add("Erro: Item pedido, não pode ficar vazio.");

            }
            if (string.IsNullOrEmpty(CEP))
            {
                AddCritical("Crítica: CEP deve ser preenchido.");
            }



            //throw new NotImplementedException();
        }
    }
}
