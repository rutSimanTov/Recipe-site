using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Repositories;

namespace Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public User GetUser(string email, string password)
        {
            return _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        public void AddUser(User user)
        { 
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
