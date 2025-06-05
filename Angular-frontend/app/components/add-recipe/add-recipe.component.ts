import { Component } from '@angular/core';
import { RecipeService } from '../../Services/recipe.service';
import { RecipeIngredientService } from '../../Services/recipeIngredient.service';
import { IngredientService } from '../../Services/ingredient.service';
import { FormsModule } from '@angular/forms';
import { Recipe } from '../../Interfaces/recipe.interface';
import { UserService } from '../../Services/user.service';
import { NgFor, NgIf } from '@angular/common';
import { Ingredient } from '../../Interfaces/ingredient.interface';
import { ImageService } from '../../Services/image.service';

@Component({
  selector: 'app-add-recipe',
  imports: [FormsModule, NgFor, NgIf],
  templateUrl: './add-recipe.component.html',
  styleUrl: './add-recipe.component.css'
})
export class AddRecipeComponent {
  recipe: Recipe = {
    id: 0, name: "", description: "", image: "", level: "easy",
    duration: 0, servingSize: 0, instructions: "", userId: 0
  }

  ingredList: Ingredient[] = []
  selectIngred: number = 1
  quantity: string = ""
  MapSelectIngred: Map<number, string> = new Map<number, string>();
  other: boolean = false
  newIngred: string = ""
  selectedFile!:File



  constructor(private recipeS: RecipeService, private recipeIngredS: RecipeIngredientService,
    private ingredientS: IngredientService, private userS: UserService,private imageS:ImageService) { }

  ngOnInit() {
    this.ingredientS.getIngredient().subscribe({
      next: (result) => {
        this.ingredList = result
      }
    })
  }

  addIngredient() {
    //הוספת רכיב חדש
    let newI: Ingredient = { id: 0, name: this.newIngred }
    this.ingredientS.addIngredient(newI).subscribe({
      next: (result) => {
        this.selectIngred = result
        this.pushIngredToMap()
        //עדכון רשימת הרכיבים עם הרכיב החדש
        this.ingredientS.getIngredient().subscribe({
          next: (result) => {
            this.ingredList = result
          }
        });
      }
    });
  }

  pushIngredToMap() {
    if (this.quantity) {
      this.MapSelectIngred.set(this.selectIngred, this.quantity)
      this.quantity = "";
    }
  }

  addRecipe() {
    this.recipe.userId = this.userS.currentUser.id;
    this.recipeS.addRecipe(this.recipe).subscribe({
      //שליפת המזהה של המתכון החדש והכנסה לפונקצית הוספת רכיבים למתכון
      next: (result) => {
        let rId = result

        if (this.MapSelectIngred.size > 0) {
          this.addRecipeIngred(rId)
        }
      }});
  }

  addRecipeIngred(recipeId: number) {
    const ingredientsDict = Object.fromEntries(this.MapSelectIngred.entries())
    this.recipeIngredS.addRecipeIngred(recipeId, ingredientsDict).subscribe();
  }


  showOther() {
    this.other = !this.other
  }

   onFileSelected(event:any){
    this.selectedFile=event.target.files[0];
  }

   uploadImage(){
    if(this.selectedFile)
      this.imageS.onUpload(this.selectedFile).subscribe({next:(response)=>{
    this.recipe.image=response.path
    }})
    else
    console.log("no file selected");
    
  }

}
