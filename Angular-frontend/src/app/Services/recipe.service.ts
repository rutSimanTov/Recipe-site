import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Recipe } from "../Interfaces/recipe.interface";

@Injectable({ providedIn: "root" })

export class RecipeService {

    // url: string =environment.baseUrl+"/Recipe"
      url: string =process.env.baseUrl+"/Recipe"


    constructor(private httpC: HttpClient) { }

    getAllRecipe(): Observable<Recipe[]> {
        return this.httpC.get<Recipe[]>(this.url)
    }

    getRecipeById(id: number): Observable<Recipe> {
        return this.httpC.get<Recipe>(`${this.url}/${id}`)
    }

    addRecipe(recipe:Recipe):Observable<number>{
        return this.httpC.post<number>(this.url,recipe)
    }

}
