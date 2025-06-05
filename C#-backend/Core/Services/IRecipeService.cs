using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IRecipeService
    {
        public IEnumerable<Recipe> GetAllRecipe();

        public Recipe GetRecipe(int id);

        public int AddRecipe(Recipe recipe);

    }
}
