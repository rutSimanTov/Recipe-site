using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Services;
using Core.Repositories;
using Core.Entities;


namespace Service.Services
{
    public class RecipeService: IRecipeService
    {
        IRecipeRepository _repository;

        public RecipeService(IRecipeRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Recipe> GetAllRecipe()
        {
            return _repository.GetAllRecipe();
        }

        public Recipe GetRecipe(int id)
        {
            return _repository.GetRecipe(id);
        }

        public int AddRecipe(Recipe recipe)
        {
            return _repository.AddRecipe(recipe);
        }
    }
}
