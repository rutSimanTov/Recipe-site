import { Routes } from '@angular/router';
import { HomePageComponent } from './components/home-page/home-page.component';
import { SignUpComponent } from './components/sign-up/sign-up.component';
import { SignInComponent } from './components/sign-in/sign-in.component';
import { AddRecipeComponent } from './components/add-recipe/add-recipe.component';
import { RecipeDatailsComponent } from './components/recipe-datails/recipe-datails.component';

export const routes: Routes = [
    {path:"",redirectTo:"/home",pathMatch:"full"},
    {path:"home",component:HomePageComponent},
    {path:"signUp",component:SignUpComponent},
    {path:"signIn",component:SignInComponent},
    {path:'addRecipe',component:AddRecipeComponent},
    {path:'recipeDetailes/:id',component:RecipeDatailsComponent}
];
