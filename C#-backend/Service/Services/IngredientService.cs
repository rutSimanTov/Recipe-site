using Core.Entities;
using Core.Repositories;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class IngredientService: IIngredientService
    {
        IIngredientRepository _repository;

        public IngredientService(IIngredientRepository repository)
        {
            _repository = repository;
        }



        public IEnumerable<Ingredient> GetAllIngredient()
        {
           return _repository.GetAllIngredient();
        }

        public int AddIngredient(Ingredient ingredient)
        {
             return _repository.AddIngredient(ingredient);
        }
    }
}
