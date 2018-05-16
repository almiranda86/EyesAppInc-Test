using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EyesAppIncTest.Models
{
    public class IngredientModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string QuantityUnit { get; set; }
        public double Alcohol { get; set; }
        public string HexaColor { get; set; }
    }
}