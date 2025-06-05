using Data;
using Microsoft.EntityFrameworkCore;
using Service.Services;
using Data.Repositories;
using Core.Services;
using Core.Repositories;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IRecipeService, RecipeService>();
builder.Services.AddScoped<IRecipeRepository, RecipeRepository>();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddScoped<IIngredientService, IngredientService>();
builder.Services.AddScoped<IIngredientRepository, IngredientRepository>();

builder.Services.AddScoped<IRecipeIngredientService, RecipeIngredientService>();
builder.Services.AddScoped<IRecipeIngredientRepository, RecipeIngredientRepository>();


builder.Services.AddDbContext<DataContext>(option =>
option.UseSqlServer(@"Server=DESKTOP-1ALELID;Database=DBRecipe;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"));


builder.Services.AddCors(options => 
    options.AddPolicy("AllowAll",
        policy=>policy.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader()
));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseStaticFiles();


app.UseAuthorization();

app.MapControllers();

app.Run();
