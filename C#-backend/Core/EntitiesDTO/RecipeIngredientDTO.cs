using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.EntitiesDTO
{
    public class RecipeIngredientDTO
    {
        public int IngredientId { get; set; }

        public string Name { get; set; }

        public string Quantity { get; set; }

        public int RecipeId { get; set; }



        public RecipeIngredientDTO() { }

        public RecipeIngredientDTO(int ingredientId, string name, string quantity, int recipeId) {
            IngredientId= ingredientId;
            Name= name;
            Quantity= quantity;
            RecipeId=recipeId;
        
        }
    }
}