import { Component, OnInit } from '@angular/core';
import { RecipeIngredientService } from '../../Services/recipeIngredient.service';
import { Recipe } from '../../Interfaces/recipe.interface';
import { ActivatedRoute } from '@angular/router';
import { RecipeService } from '../../Services/recipe.service';
import { NgFor, NgIf } from '@angular/common';
import { RecipeIngredientDTO } from '../../Interfaces/recipe-ingredient-DTO.iterface';
import { MinutePipe } from '../../pipe/minute.pipe';
import { HourPipe } from '../../pipe/hour.pipe';
import { DurationPipe } from '../../pipe/duration.pipe';


@Component({
  selector: 'app-recipe-datails',
  imports: [NgFor, NgIf, MinutePipe, HourPipe, DurationPipe],
  templateUrl: './recipe-datails.component.html',
  styleUrl: './recipe-datails.component.css'
})

export class RecipeDatailsComponent implements OnInit {

  constructor(private route: ActivatedRoute, private recipeS: RecipeService, private recipeIngredS: RecipeIngredientService) { }

  recipe: Recipe = {
    id: 0, name: "", description: "", image: "", level: "",
    duration: 0, servingSize: 0, instructions: "", userId: 0
  }

  // imgUrl: string =  process.env['baseUrl']+"/images/"
    imgUrl: string = environment.baseUrl+"/images/"



  ingredients: RecipeIngredientDTO[] = []

  ngOnInit() {
    this.route.params.subscribe(params => {
      this.recipe.id = +params['id'];
      this.getRecipeById(this.recipe.id);
      this.getIngredientByRecipeId(this.recipe.id)
    })
  }

  getRecipeById(recipeId: number) {
    this.recipeS.getRecipeById(recipeId).subscribe({
      next: (result) => {
        this.recipe = result

      }
    })
  }

  getIngredientByRecipeId(recipeId: number) {
    this.recipeIngredS.getRecipeIngred(recipeId).subscribe({
      next: (data) => {
        this.ingredients = data

      }
    })
  }


}
