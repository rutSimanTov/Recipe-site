using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Repositories;
using Core.Services;

namespace Service.Services
{
    public class UserService:IUserService
    {
        IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public User GetUser(string email, string password)
        {
            return _repository.GetUser(email, password);
        }

        public void AddUser(User user)
        {
            _repository.AddUser(user);
        }
    }
}
