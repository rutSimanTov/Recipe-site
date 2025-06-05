using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IIngredientRepository
    {
        public IEnumerable<Ingredient> GetAllIngredient();

        public int AddIngredient(Ingredient ingredient);



    }
}
