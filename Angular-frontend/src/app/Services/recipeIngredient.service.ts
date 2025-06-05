import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { RecipeIngredient } from "../Interfaces/recipe-ingredient.interface";
import { RecipeIngredientDTO } from "../Interfaces/recipe-ingredient-DTO.iterface";

@Injectable({ providedIn: "root" })

export class RecipeIngredientService {

    url: string = "https://localhost:7054/RecipeIngredient"
    

    constructor(private httpC: HttpClient) { }

    getRecipeIngred(recipeId: number): Observable<RecipeIngredientDTO[]> {
        return this.httpC.get<RecipeIngredientDTO[]>(`${this.url}/${recipeId}`)
    }

    addRecipeIngred(recipeId: number, ingredientsDict: Record<number, string>): Observable<RecipeIngredient> {
        
        return this.httpC.post<RecipeIngredient>(`${this.url}/${recipeId}`, ingredientsDict)
    }

}