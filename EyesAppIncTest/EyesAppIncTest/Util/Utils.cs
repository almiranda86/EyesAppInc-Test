using EyesAppIncTest.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace EyesAppIncTest.Util
{
    public static class Utils
    {
        public static string GetHexaDrink(List<IngredientModel> OrderIngredient)
        {
            int R = 0;
            int G = 0;
            int B = 0;
            int A = 0;

            foreach (IngredientModel ingridient in OrderIngredient)
            {
                if (!string.IsNullOrEmpty(ingridient.HexaColor))
                {
                    Color color = System.Drawing.ColorTranslator.FromHtml(ingridient.HexaColor);
                    R = R + color.R;
                    G = G + color.G;
                    B = B + color.B;
                    A = A + color.A;
                }
            }

            if (A > 255) { A = 255; }

            if (R > 255) { R = 255; }

            if (G > 255) { G = 255; }

            if (B > 255) { B = 255; }


            String hexColor = System.Drawing.ColorTranslator.ToHtml(Color.FromArgb(A, R, G, B));

            return hexColor;
        }

        public static double SumAlcohol(List<IngredientModel> OrderIngredient)
        {

            double alcoholTotal = 0;

            foreach (IngredientModel ingridient in OrderIngredient)
            {
                alcoholTotal += ingridient.Alcohol;
            }

            return alcoholTotal;
        }
    }
}