using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EyesAppIncTest.Business;

namespace EyesAppIncTest.Controllers
{
    public class CocktailController : ApiController
    {

        [HttpGet]
        public string HelloWorld()
        {
            return "Hey!";
        }

        [HttpGet]
        public IEnumerable<Models.CocktailModel> GetExistingCocktailsWithParticularAmountOfAlcohol(double percentageOfAlcohol)
        {
            CocktailBusiness business = new CocktailBusiness();
            var lista = business.GetCocktailWithParticuarAmountouOfAlcohol(percentageOfAlcohol);

            return lista;
        }

        [HttpGet]
        [Route("api/Cocktail/GetNewGeneratedCocktail/{numberOfIngridients?}/{finalPercentageOfAlcohol?}/{drinkName?}/")]
        public IEnumerable<Models.CocktailModel> GetNewGeneratedCocktail(int numberOfIngridients = 0, double finalPercentageOfAlcohol = 0, string drinkName = "")
        {
            CocktailBusiness business = new CocktailBusiness();
            var lista = business.GetNewGeneratedCocktail(numberOfIngridients, finalPercentageOfAlcohol, drinkName);

            business.InsertNewGeneratedCocktail(lista);

            return lista;
        }
    }
}