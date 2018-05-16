using EyesAppIncTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EyesAppIncTest.DB
{
    public class Context : DbContext
    {
        public DbSet<CocktailModel> Cocktail { get; set; }
        public DbSet<IngredientModel>Ingridient { get; set; }
    }
}