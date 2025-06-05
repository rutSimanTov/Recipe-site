using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Repositories;


namespace Data.Repositories
{
    public class IngredientRepository: IIngredientRepository
    {
        DataContext _context;

        public IngredientRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Ingredient> GetAllIngredient()
        {
            return _context.Ingredients;
        }

        public int AddIngredient(Ingredient ingredient)
        { 
            _context.Ingredients.Add(ingredient);
            _context.SaveChanges();
            return ingredient.Id;

        }

    }
}
