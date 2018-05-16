using EyesAppIncTest.DAO;
using EyesAppIncTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EyesAppIncTest.Business
{
    public class CocktailBusiness
    {
        CocktailDAO cocktailDAO = null;
        IngredientsDAO ingredientsDAO = null;
        CocktailIngredientDAO cocktailIngredientDAO = null;

        public List<CocktailModel> GetCocktailWithParticuarAmountouOfAlcohol(double alcohol)
        {
            List<CocktailModel> cocktailModels = null;

            cocktailDAO = new CocktailDAO();

            cocktailModels = cocktailDAO.GetCocktailWithParticuarAmountouOfAlcohol(alcohol);

            int idCocktail = 0;
            List<CocktailModel> cocktailReturnColl = new List<CocktailModel>();
            CocktailModel cocktailReturn = null;

            if (cocktailModels != null)
            {
                foreach (var cocktail in cocktailModels)
                {
                    var id = cocktail.Id;

                    if (idCocktail != id)
                    {
                        idCocktail = id;
                        cocktailReturn = new CocktailModel();
                        cocktailReturn = cocktail;
                        cocktailReturnColl.Add(cocktailReturn);
                    }
                    else
                    {
                        cocktailReturn.OrderIngredient.Add(cocktail.OrderIngredient[0]);
                    }

                }
            }

            return cocktailReturnColl;
        }

        public List<CocktailModel> GetNewGeneratedCocktail(int numberOfIngridients, double finalPercentageOfAlcohol, string drinkName)
        {
            List<CocktailModel> cocktailReturnColl = new List<CocktailModel>();
            CocktailModel cocktailReturn = null;
            List<IngredientModel> ingredientColl = null;

            cocktailDAO = new CocktailDAO();
            ingredientsDAO = new IngredientsDAO();

            if (numberOfIngridients == 0)
            {
                numberOfIngridients = 2;
            }

            if (finalPercentageOfAlcohol == 0)
            {
                finalPercentageOfAlcohol = 0.15;
            }

            ingredientColl = ingredientsDAO.ListAll();

            cocktailReturn = new CocktailModel();
            cocktailReturn.Name = "".Equals(drinkName) ? "New Drink" : drinkName;

            Random r = new Random();
            for (int i = 0; i < numberOfIngridients; i++)
            {
                int x = r.Next(ingredientColl.Count);
                var ingridient = ingredientColl[x];
                if (cocktailReturn.OrderIngredient == null)
                {
                    cocktailReturn.OrderIngredient = new List<IngredientModel>();
                    cocktailReturn.OrderIngredient.Add(ingridient);
                }
                else
                {
                    if (cocktailReturn.OrderIngredient.Exists(item => item.Name == "Champagne"))
                    {
                        if (ingridient.Name.Equals("Campari"))
                        {
                            cocktailReturn.OrderIngredient.Add(ingredientColl.Single(item => item.Name != "Campari"));
                        }
                    }
                    else if (cocktailReturn.OrderIngredient.Exists(item => item.Name == "Campari"))
                    {
                        {
                            if (ingridient.Name.Equals("Champagne"))
                            {
                                cocktailReturn.OrderIngredient.Add(ingredientColl.Single(item => item.Name != "Champagne"));
                            }
                        }
                    }
                    else
                    {
                        cocktailReturn.OrderIngredient.Add(ingridient);
                    }
                }
            }

            if (Util.Utils.SumAlcohol(cocktailReturn.OrderIngredient) <= finalPercentageOfAlcohol)
            {
                cocktailReturn.HexadecimalColor = Util.Utils.GetHexaDrink(cocktailReturn.OrderIngredient);
                cocktailReturn.PercentageOfAlcohol = Util.Utils.SumAlcohol(cocktailReturn.OrderIngredient);
                cocktailReturnColl.Add(cocktailReturn);
            }

            return cocktailReturnColl;
        }

        public void InsertNewGeneratedCocktail(List<CocktailModel> cocktailColl)
        {
            cocktailDAO = new CocktailDAO();
            cocktailIngredientDAO = new CocktailIngredientDAO();

            foreach (var cocktail in cocktailColl)
            {
                var idCocktail = cocktailDAO.InsertNewGeneratedCocktail(cocktail);

                foreach (var cocktailItens in cocktail.OrderIngredient)
                {
                    var idItemCocktail = cocktailIngredientDAO.InsertNewGeneratedCocktail(cocktailItens, idCocktail);
                }
            }
        }
    }
}