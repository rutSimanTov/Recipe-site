# 🍽️ Recipe Sharing Web Application

A full-stack recipe-sharing web application built with **Angular**, **C# (ASP.NET Core)**, and **SQL Server**. This platform allows users to browse, add, and share recipes with ease. Whether you're a beginner or a seasoned chef, the app provides a user-friendly interface to discover new recipes, share your own, and manage your collection.

## 📝 Table of Contents

* [Overview](#overview)
* [Features](#features)
* [Tech Stack](#tech-stack)
* [Installation](#installation)
* [Usage](#usage)
* [API Documentation](#api-documentation)
* [Detailed Structure of the Data Layer](#detailed-structure-of-the-data-layer)
* [Contributing](#contributing)

## 📜 Overview

This web application allows users to **share and discover recipes**. Users can browse recipes, add their own, and view detailed information, including ingredients, cooking instructions, and difficulty levels.

Key features include:

* **Browse Recipes**: Discover recipes with details such as name, image, and difficulty level (Easy, Medium, Hard).
* **User Authentication**: Register and log in to add your own recipes.
* **Recipe Management**: Add new recipes, upload images, and select ingredients from a predefined list (or add new ones).
* **Ingredient Selector**: Manage ingredients linked to recipes.
* **No Admin Role**: Anyone with an account can add recipes. There are no admin roles.

The app uses **Angular** for the frontend, **C# (ASP.NET Core)** for the backend, and **SQL Server** as the database.

## 🚀 Features

* **Home Page**: Displays a collection of recipe cards with images, names, and difficulty levels.
* **Recipe Details**: Clicking a recipe card reveals detailed information, including ingredients, instructions, and servings.
* **User Authentication**: Register and log in to add recipes and manage your personal collection.
* **Add Recipe**: Logged-in users can submit new recipes with name, ingredients, image, cooking instructions, and difficulty.
* **Ingredient Selector**: Choose from predefined ingredients or add new ones.
* **No Admin Role**: All registered users have equal access to adding recipes. No admin permissions are required.
* **Responsive Design**: The app works seamlessly on both desktop and mobile devices.

## ⚙️ Tech Stack

* **Frontend**: **Angular** for building the user interface.
* **Backend**: **C# (ASP.NET Core)** with four-layer architecture (Data, Service, Core, API).

  * **Data Layer**: Directly interacts with SQL Server database via Entity Framework.
  * **Service Layer**: Business logic and data manipulation.
  * **Core Layer**: Entity models and DTOs (Data Transfer Objects).
  * **API Layer**: Exposes RESTful endpoints to interact with the frontend.
* **Database**: **SQL Server**, used for storing recipes, users, and ingredients.
* **Authentication**: Basic user authentication using session-based authentication.
* **ORM**: **Entity Framework Core**.
* **API Documentation**: **Swagger** (auto-generated) for easy API exploration.

## 📥 Installation

### Prerequisites

Before setting up the project, make sure you have the following installed:

* [.NET 8.0 SDK](https://dotnet.microsoft.com/download)
* [Node.js](https://nodejs.org/)
* [Angular CLI](https://angular.io/cli)
* [SQL Server](https://www.microsoft.com/en-us/sql-server)

### Step-by-Step Setup

1. **Clone the repository**:

```bash
git clone https://github.com/your-username/recipe-sharing-app.git
cd recipe-sharing-app
```

2. **Backend Setup (C# / ASP.NET Core)**

   * Navigate to the `API` project directory.
   * Restore dependencies:

   ```bash
   dotnet restore
   ```

   * Apply the database migrations:

   ```bash
   dotnet ef database update
   ```

   * Run the application:

   ```bash
   dotnet run
   ```

   The backend will run on `http://localhost:5000` by default.

3. **Frontend Setup (Angular)**

   * Navigate to the `frontend` directory:

   ```bash
   cd frontend
   ```

   * Install the required npm packages:

   ```bash
   npm install
   ```

   * Start the Angular development server:

   ```bash
   ng serve
   ```

   The frontend will be available at `http://localhost:4200`.

### Database Configuration

Ensure that the `appsettings.json` file in the backend project has the correct connection string for your SQL Server instance.

Example:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=DESKTOP-1ALELID;Database=DBRecipe;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"
  }
}
```

## 🖥️ Usage

1. Open the app in your browser (`http://localhost:4200`).
2. On the homepage, browse through recipe cards. Each card shows the recipe name, image, and difficulty level.
3. If you’re a new user, click the "Register" link in the navigation bar to create an account.
4. Once registered, log in and click the "Add Recipe" link to add your own recipe.
5. Fill in the form with the recipe name, ingredients, image, and difficulty level.
6. After submitting, the new recipe will be available for other users to view.

## 🛠️ API Documentation

The application exposes the following API endpoints:

### Recipe API

* **GET** `/api/recipes`: Retrieve a list of all recipes.
* **GET** `/api/recipes/{id}`: Retrieve details for a specific recipe.
* **POST** `/api/recipes`: Add a new recipe (authentication required).

### Ingredient API

* **GET** `/api/ingredients`: Retrieve a list of all ingredients.
* **POST** `/api/ingredients`: Add a new ingredient (authentication required).

### User API

* **POST** `/api/users/register`: Register a new user.
* **POST** `/api/users/login`: Log in an existing user.

**Note**: Recipe and ingredient data is stored in multiple tables in SQL Server, including `Recipes`, `Ingredients`, `RecipeIngredients`, and `Users`. The API interacts with these tables through the following C# repositories:

* **RecipeRepository**: Handles CRUD operations related to recipes.
* **IngredientRepository**: Manages ingredient data.
* **RecipeIngredientRepository**: Maps ingredients to recipes.

API responses are enriched with data transfer objects (DTOs), such as `RecipeIngredientDTO`, which provide detailed information about the recipe ingredients and quantities.

API endpoints are auto-documented using **Swagger** and can be accessed at `http://localhost:5000/swagger`.

## **Detailed Structure of the Data Layer:**

Your data layer interacts with the SQL Server database through Entity Framework Core. The primary entities are:

* **Recipe**: Represents a recipe with fields like `Name`, `Description`, `Level`, `Duration`, `ServingSize`, and a list of `Ingredients`.
* **Ingredient**: Represents an ingredient, which can be associated with multiple recipes.
* **RecipeIngredient**: Maps the relationship between `Recipe` and `Ingredient` along with the `Quantity` used.
* **User**: Stores user information such as `Name`, `Email`, and `Password`.

The repositories interact with these entities as follows:

* **RecipeRepository**: Manages the `Recipes` table.
* **IngredientRepository**: Manages the `Ingredients` table.
* **RecipeIngredientRepository**: Manages the many-to-many relationship between recipes and ingredients, storing quantities.
* 

## 🤝 Contributing

Contributions are welcome! If you'd like to contribute, follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Make your changes.
4. Commit your changes (`git commit -am 'Add new feature'`).
5. Push to your fork (`git push origin feature-branch`).
6. Create a pull request.

---

