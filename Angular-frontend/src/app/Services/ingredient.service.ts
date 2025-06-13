import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Ingredient } from "../Interfaces/ingredient.interface";

@Injectable({ providedIn: "root" })

export class IngredientService {
    
    url = environment.baseUrl+"/Ingredient"

    constructor(private httpC: HttpClient) { }

    getIngredient():Observable<Ingredient[]>{
        return this.httpC.get<Ingredient[]>(this.url)
    }

    addIngredient(ingredient:Ingredient):Observable<number>{
        return this.httpC.post<number>(this.url,ingredient)
    }
   
}
