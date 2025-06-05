using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IIngredientService
    {
        public IEnumerable<Ingredient> GetAllIngredient();

        public int AddIngredient(Ingredient ingredient);
    }
}
