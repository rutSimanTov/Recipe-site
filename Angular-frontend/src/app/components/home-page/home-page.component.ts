import { Component } from '@angular/core';
import { RecipeService } from '../../Services/recipe.service';
import { Recipe } from '../../Interfaces/recipe.interface';
import { NgFor, NgIf } from '@angular/common';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home-page',
  imports: [NgFor, NgIf],
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.css'
})
export class HomePageComponent {
  recipeArr: Recipe[] = []
  error: string = '';
  // imgUrl: string = process.env['baseUrl']+"/images/"
    imgUrl: string = environment.baseUrl+"/images/"



  constructor(private recipeS: RecipeService, private router: Router) { }

  ngOnInit(): void {
    this.recipeS.getAllRecipe().subscribe({
      next: (data) => {
        this.recipeArr = data;
      },
      error: (err) => {
        this.error = 'אירעה שגיאה בטעינת המתכונים';
      }
    });
  }

  moreData(recipeId: number) {
    this.router.navigate(['/recipeDetailes', recipeId])
  }

}




