using System;
using System.Collections.Generic;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data;

public partial class DataContext : DbContext
{
    public DataContext()
    {
    }

    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ingredient> Ingredients { get; set; }

    public virtual DbSet<Recipe> Recipes { get; set; }

    public virtual DbSet<RecipeIngredient> RecipeIngredients { get; set; }
    
    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Recipe>(entity =>
        {
            entity.HasOne(d => d.User).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Recipes_Users");
        });

        modelBuilder.Entity<RecipeIngredient>(entity =>
        {
            entity.HasOne(d => d.Ingredient).WithMany(p => p.RecipeIngredients)
                .HasForeignKey(d => d.IngredientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecipeIngredients_Ingredients");

            entity.HasOne(d => d.Recipe).WithMany(p => p.RecipeIngredients)
                .HasForeignKey(d => d.RecipeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecipeIngredients_Recipes");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
