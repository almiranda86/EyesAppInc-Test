namespace EyesAppIncTest.Migrations
{
    using EyesAppIncTest.Helper;
    using EyesAppIncTest.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EyesAppIncTest.DB.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EyesAppIncTest.DB.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
           
            List<CocktailModel> cockTailColl = Helper.SeedModel.SeedCocktail();

            foreach (var cockTail in cockTailColl) {
                cockTail.HexadecimalColor = Util.Utils.GetHexaDrink(cockTail.OrderIngredient);
                cockTail.PercentageOfAlcohol = Util.Utils.SumAlcohol(cockTail.OrderIngredient);
            }

            context.Cocktail.AddOrUpdate(
                cockTailColl.ToArray()
            );


            context.Ingridient.AddOrUpdate(
                Helper.SeedModel.SeedIngridient().ToArray()
            );
        }
    }
}
