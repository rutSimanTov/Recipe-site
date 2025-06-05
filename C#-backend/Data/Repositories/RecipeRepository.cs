using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Repositories;

namespace Data.Repositories
{
    public class RecipeRepository: IRecipeRepository
    {
        DataContext _context;
        public RecipeRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Recipe> GetAllRecipe()
        {
            return _context.Recipes;
        }

        public Recipe GetRecipe(int id) 
        {
            return _context.Recipes.FirstOrDefault(r => r.Id == id);
        }

        public int AddRecipe(Recipe recipe)
        {
            _context.Recipes.Add(recipe);
            _context.SaveChanges();
            return recipe.Id;
            
        }
    }
}
