using Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet("{email}/{password}")]
        public User GetUser(string email, string password)
        {
            return _service.GetUser(email, password);
        }

        [HttpPost]
        public void AddUser([FromBody]User user)
        {
            _service.AddUser(user);
        }


    }
}
