using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EyesAppIncTest.Models
{
    public class CocktailModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<IngredientModel> OrderIngredient { get; set; }
        public double PercentageOfAlcohol { get; set; }
        public string HexadecimalColor { get; set; }
    }
}