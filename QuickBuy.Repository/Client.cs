using QuickBuy.Domain.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Repositories
{
    public class Client
    {
        public Client()
        {
            var userRepository = new UserRepository();
            var user = new User();
            var product = new Product();
            userRepository.Add(user);
        }
    }
}
