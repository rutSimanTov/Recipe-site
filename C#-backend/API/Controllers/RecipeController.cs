using Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipeController : Controller
    {
        private readonly IRecipeService _service;

        public RecipeController(IRecipeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Recipe> GetAllRecipe()
        {
            return _service.GetAllRecipe();
        }


        [HttpGet("{id}")]
        public Recipe GetRecipe(int id)
        {
            return _service.GetRecipe(id);
        }

        [HttpPost]
        public int AddRecipe([FromBody]Recipe recipe)
        {
            return _service.AddRecipe(recipe);
        }
    }
}