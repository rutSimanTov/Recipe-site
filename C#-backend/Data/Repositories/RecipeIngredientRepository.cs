using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.EntitiesDTO;
using Core.Repositories;


namespace Data.Repositories
{
    public class RecipeIngredientRepository: IRecipeIngredientRepository
    {
        DataContext _context;
        public RecipeIngredientRepository(DataContext context)
        { 
            _context = context;
        }

        public List<RecipeIngredientDTO> GetIngredToRecipe(int recipeId)
        {
            //var ingredientId= _context.RecipeIngredients.Where(i=>i.RecipeId == recipeId)
            //     .Select(i=>i.IngredientId).ToList();


            // List<Ingredient> ingredients = new List<Ingredient>();


            // foreach (var item in ingredientId) 
            //     ingredients.Add(_context.Ingredients.First(a => a.Id == item));

            // return ingredients;
            //----------------------------------------------------
            ///---------------------------------------------------
            
            //var ingredientList = _context.RecipeIngredients.Where(i => i.RecipeId == recipeId).ToList();

            //Dictionary<Ingredient, string> ingredDict = new Dictionary<Ingredient, string>();
            //foreach (var item in ingredientList)
            //{
            //    Ingredient key = _context.Ingredients.FirstOrDefault(a => a.Id == item.Id);
            //    if (key != null)
            //    {
            //        string value = item.Quantity;
                
            //        ingredDict.Add(key, value);}
            //}
            //return ingredDict;

            var ingredientList = _context.RecipeIngredients.Where(i => i.RecipeId == recipeId).ToList();

            List<RecipeIngredientDTO> ingredientDTO = new List<RecipeIngredientDTO>();

            foreach(var ingredient in ingredientList)
            {
                string name="";
                var ingred = _context.Ingredients.FirstOrDefault(a => a.Id == ingredient.IngredientId);
                if (ingred != null)
                    name = ingred.Name;
                ingredientDTO.Add(new RecipeIngredientDTO( ingredient.IngredientId, name, ingredient.Quantity, recipeId));
            }

            return ingredientDTO;

        }

        public void AddIngred(int recipeId, Dictionary <int,string>ingredientsId)
        {
            foreach (var item in ingredientsId)
            {
                _context.RecipeIngredients.Add(new RecipeIngredient { RecipeId = recipeId, IngredientId = item.Key,Quantity=item.Value });
            }
            _context.SaveChanges();
            
        }
    }
}


