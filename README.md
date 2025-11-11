# 🍽️ Recipe Sharing Web Application

A full-stack recipe sharing web application built with Angular, C#, and SQL Server. This platform allows users to browse, add, and share recipes. Whether you're a beginner or a seasoned chef, the app provides an easy way to discover new recipes, share your own, and manage your collection.

## 📝 Table of Contents

* [Overview](#overview)
* [Features](#features)
* [Tech Stack](#tech-stack)
* [Installation](#installation)
* [Usage](#usage)
* [API Documentation](#api-documentation)
* [Contributing](#contributing)
* [License](#license)

## 📜 Overview

This web application enables food lovers to share and discover recipes. It allows users to:

* Browse recipe cards with key details (name, image, difficulty level).
* Register and log in to add their own recipes.
* Upload images of their recipes.
* Select ingredients from a predefined list or add new ingredients.
* View detailed information about each recipe.

There are **no admin roles**, meaning anyone who registers can contribute their recipes. The application uses Angular for the frontend, C# for the backend, and SQL Server for the database.

## 🚀 Features

* **Home Page**: Displays a collection of recipe cards with images, names, and difficulty levels (Easy, Medium, Hard).
* **Recipe Details**: Clicking on a recipe card takes you to a detailed page with all the information about the recipe.
* **User Authentication**: Allows users to register and log in.
* **Add Recipe**: Once logged in, users can add their own recipes, including the name, image, ingredients, and difficulty level.
* **Ingredient Selector**: Users can choose from existing ingredients or add new ones.
* **No Admin Role**: Only registered users can add new recipes. No admin permissions are required.
* **Responsive Design**: The application is mobile-friendly and works across different screen sizes.

## ⚙️ Tech Stack

* **Frontend**: Angular
* **Backend**: C# (ASP.NET Core)
* **Database**: SQL Server
* **Authentication**: Basic user authentication (session-based)
* **API Documentation**: Swagger (auto-generated)
* **ORM**: Entity Framework Core

## 📥 Installation

### Prerequisites

Before setting up the project, ensure you have the following installed:

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
   * Restore the dependencies:

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

* **GET** `/api/recipes`: Retrieve a list of all recipes.
* **GET** `/api/recipes/{id}`: Retrieve details for a specific recipe.
* **POST** `/api/recipes`: Add a new recipe (authentication required).
* **GET** `/api/ingredients`: Retrieve a list of all ingredients.
* **POST** `/api/ingredients`: Add a new ingredient (authentication required).
* **POST** `/api/users/register`: Register a new user.
* **POST** `/api/users/login`: Log in an existing user.

The full API documentation can be accessed via Swagger at `http://localhost:5000/swagger`.

## 🤝 Contributing

Contributions are welcome! If you'd like to contribute, follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Make your changes.
4. Commit your changes (`git commit -am 'Add new feature'`).
5. Push to your fork (`git push origin feature-branch`).
6. Create a pull request.

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.


