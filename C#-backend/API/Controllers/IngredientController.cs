using Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class IngredientController : Controller
    {

        private readonly IIngredientService _service;

        public IngredientController(IIngredientService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Ingredient> GetAllIngredient()
        {
            return _service.GetAllIngredient();
        }


        [HttpPost]
        public int AddIngredient([FromBody]Ingredient ingredient)
        {
           return _service.AddIngredient(ingredient);
        }

    }
}
