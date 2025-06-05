using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Core.Services;
using Core.Entities;
using Core.EntitiesDTO;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipeIngredientController : Controller
    {
        private readonly IRecipeIngredientService _service;

        public RecipeIngredientController(IRecipeIngredientService service)
        {
            _service = service;
        }

        [HttpGet("{recipeId}")]
        public List<RecipeIngredientDTO> GetIngredToRecipe(int recipeId)
        {
            return _service.GetIngredToRecipe(recipeId);
        }

        [HttpPost("{recipeId}")]
        public void AddIngred( int recipeId, [FromBody] Dictionary<int,string> ingredientsId)
        {
            _service.AddIngred(recipeId, ingredientsId);
        }





    }
}
