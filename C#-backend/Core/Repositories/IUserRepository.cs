using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IUserRepository
    {
        public User GetUser(string email, string password);

        public void AddUser(User user);


    }
}
