using Core.Entities;
using Core.Services;
using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.EntitiesDTO;

namespace Service.Services
{
    public class RecipeIngredientService: IRecipeIngredientService
    {
        private readonly IRecipeIngredientRepository _repository;

        public RecipeIngredientService(IRecipeIngredientRepository repository)
        {
            _repository = repository;
        }
        public List<RecipeIngredientDTO> GetIngredToRecipe(int recipeId)
        {
            return _repository.GetIngredToRecipe(recipeId);
        }

        public void AddIngred(int recipeId, Dictionary<int, string> ingredientsId)
        {
            _repository.AddIngred(recipeId, ingredientsId); 
        }


    }
}
