using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Recipe
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string Level { get; set; } = null!;

    public int Duration { get; set; }

    public int ServingSize { get; set; }

    public string Instructions { get; set; } = null!;

    public int UserId { get; set; }

    public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();

    public virtual User? User { get; set; }
}
