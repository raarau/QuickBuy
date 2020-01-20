using System.Collections.Generic;

namespace QuickBuy.Domain.Entityes
{
    public class User : Entity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public ICollection<Order> Orders { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
