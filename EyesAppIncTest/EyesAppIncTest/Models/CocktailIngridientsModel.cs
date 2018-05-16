using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EyesAppIncTest.Models
{
    public class CocktailIngridientsModel
    {
        public int Id { get; set; }
        public int CocktailId { get; set; }
        public int IngridientId { get; set; }
    }
}