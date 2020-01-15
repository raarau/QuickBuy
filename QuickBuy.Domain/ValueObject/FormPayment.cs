using QuickBuy.Domain.Enumerable;

namespace QuickBuy.Domain.ValueObject
{
    public class FormPayment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsBillet
        {
            get { return Id == (int) FormPaymentTypeEnum.Billet; }
        }

        public bool IsCreditCard
        {
            get { return Id == (int)FormPaymentTypeEnum.CreditCard; }
        }

        public bool IsDeposit
        {
            get { return Id == (int)FormPaymentTypeEnum.Deposit; }
        }

        public bool IsNotDefinied
        {
            get { return Id == (int)FormPaymentTypeEnum.NotDefinied; }
        }
    }
}
