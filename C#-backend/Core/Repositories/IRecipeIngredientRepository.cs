using Core.Entities;
using Core.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IRecipeIngredientRepository
    {
        public List<RecipeIngredientDTO> GetIngredToRecipe(int recipeId);

        public void AddIngred(int recipeId, Dictionary<int, string> ingredientsId);


    }
}
