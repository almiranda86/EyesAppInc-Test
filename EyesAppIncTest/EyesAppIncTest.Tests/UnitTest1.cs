using System;
using System.Collections.Generic;
using EyesAppIncTest.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EyesAppIncTest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<CocktailModel> cockTailColl = Helper.SeedModel.SeedCocktail();

            foreach (var cockTail in cockTailColl)
            {
                cockTail.HexadecimalColor = Util.Utils.GetHexaDrink(cockTail.OrderIngredient);
                cockTail.PercentageOfAlcohol = Util.Utils.SumAlcohol(cockTail.OrderIngredient);
            }
        }
    }
}
