using EyesAppIncTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EyesAppIncTest.Helper
{
    public static class SeedModel
    {
        public static List<CocktailModel> SeedCocktail()
        {
            List<CocktailModel> CocktailCollection = new List<CocktailModel>();

            CocktailCollection.Add(new CocktailModel()
            {
                Id = 1,
                Name = "Americano",
                OrderIngredient = new List<IngredientModel>()
                {
                    new IngredientModel
                    {
                        Id=1,
                        Name = "Campari",
                        Quantity = 35,
                        QuantityUnit = "millilitres",
                        Alcohol = 25,
                        HexaColor = "#FF0104"
                    },

                    new IngredientModel
                    {
                        Id=2,
                        Name = "Cinzano",
                        Quantity = 35,
                        QuantityUnit = "millilitres",
                        Alcohol = 15,
                        HexaColor = "#6D1410"
                    }
                }
            });


            CocktailCollection.Add(new CocktailModel()
            {
                Id = 2,
                Name = "Moët Golden Glamour",
                OrderIngredient = new List<IngredientModel>
                {
                    new IngredientModel
                    {
                        Id=3,
                        Name = "Champagne",
                        Quantity = 120,
                        QuantityUnit = "millilitres",
                        Alcohol = 12.5,
                        HexaColor = "#FEEE8D"
                    },
                    new IngredientModel
                    {
                        Id=4,
                        Name = "Vanilla liqueur",
                        Quantity = 40,
                        QuantityUnit = "millilitres",
                        Alcohol = 40,
                        HexaColor = "#A84000"
                    },
                    new IngredientModel
                    {
                         Id=5,
                        Name = "Passion fruit juice",
                        Quantity = 80,
                        QuantityUnit = "millilitres",
                        Alcohol = 0,
                        HexaColor = "#F8A802"
                    }
                }

            });


            CocktailCollection.Add(new CocktailModel()
            {
                Id = 3,
                Name = "Campagne in love",

                OrderIngredient = new List<IngredientModel>
                {
                    new IngredientModel
                    {
                        Id=3,
                        Name = "Champagne",
                        Quantity = 125,
                        QuantityUnit = "millilitres",
                        Alcohol = 12.5,
                        HexaColor = "#FEEE8D"
                    },
                    new IngredientModel
                    {
                        Id=6,
                        Name = "Angostura",
                        Quantity = 5,
                        QuantityUnit = "millilitres",
                        Alcohol = 44.7,
                        HexaColor = "#2F0405"
                    },
                     new IngredientModel
                    {
                        Id=7,
                        Name = "Sugar",
                        Quantity = 3,
                        QuantityUnit = "grams",
                        Alcohol = 0,
                        HexaColor = ""
                    }
                }
            });


            CocktailCollection.Add(new CocktailModel()
            {
                Id = 4,
                Name = "Blue Lagoon",

                OrderIngredient = new List<IngredientModel>
                {
                    new IngredientModel
                    {
                        Id=8,
                        Name = "Curacao",
                        Quantity = 15,
                        QuantityUnit = "millilitres",
                        Alcohol = 20,
                        HexaColor = "#2EE5EC"
                    },
                    new IngredientModel
                    {
                        Id=9,
                        Name = "Vodka",
                        Quantity = 45,
                        QuantityUnit = "millilitres",
                        Alcohol = 40,
                        HexaColor = "#FFFFFF"
                     },
                    new IngredientModel
                    {
                        Id=10,
                        Name = "Lemon juice",
                        Quantity = 15,
                        QuantityUnit = "millilitres",
                        Alcohol = 0,
                        HexaColor = "#FFFFFF"
                    },
                    new IngredientModel
                    {
                        Id=11,
                        Name = "Ginger",
                        Quantity = 2,
                        QuantityUnit = "grams",
                        Alcohol = 0,
                        HexaColor = ""
                    }
                }
            });

            return CocktailCollection;
        }


        public static List<IngredientModel> SeedIngridient()
        {
            List<IngredientModel> IngredientCollection = new List<IngredientModel>();

            IngredientCollection.Add
            (
                new IngredientModel
                {
                    Id = 1,
                    Name = "Campari",
                    Quantity = 35,
                    QuantityUnit = "millilitres",
                    Alcohol = 25,
                    HexaColor = "#FF0104"
                }
            );

            IngredientCollection.Add
            (
                new IngredientModel
                {
                    Id = 2,
                    Name = "Cinzano",
                    Quantity = 35,
                    QuantityUnit = "millilitres",
                    Alcohol = 15,
                    HexaColor = "#6D1410"
                }
            );

            IngredientCollection.Add
            (
                new IngredientModel
                {
                    Id = 3,
                    Name = "Champagne",
                    Quantity = 120,
                    QuantityUnit = "millilitres",
                    Alcohol = 12.5,
                    HexaColor = "#FEEE8D"
                }
            );

            IngredientCollection.Add
            (
                new IngredientModel
                {
                    Id = 4,
                    Name = "Vanilla liqueur",
                    Quantity = 40,
                    QuantityUnit = "millilitres",
                    Alcohol = 40,
                    HexaColor = "#A84000"
                }
            );

            IngredientCollection.Add
            (
                new IngredientModel
                {
                    Id = 5,
                    Name = "Passion fruit juice",
                    Quantity = 80,
                    QuantityUnit = "millilitres",
                    Alcohol = 0,
                    HexaColor = "#F8A802"
                }
            );

            IngredientCollection.Add
            (
                new IngredientModel
                {
                    Id = 6,
                    Name = "Angostura",
                    Quantity = 5,
                    QuantityUnit = "millilitres",
                    Alcohol = 44.7,
                    HexaColor = "#2F0405"
                }
            );

            IngredientCollection.Add
            (
                new IngredientModel
                {
                    Id = 7,
                    Name = "Sugar",
                    Quantity = 3,
                    QuantityUnit = "grams",
                    Alcohol = 0,
                    HexaColor = ""
                }
            );

            IngredientCollection.Add
            (
                new IngredientModel
                {
                    Id = 8,
                    Name = "Curacao",
                    Quantity = 15,
                    QuantityUnit = "millilitres",
                    Alcohol = 20,
                    HexaColor = "#2EE5EC"
                }
            );

            IngredientCollection.Add
            (
                new IngredientModel
                {
                    Id = 9,
                    Name = "Vodka",
                    Quantity = 45,
                    QuantityUnit = "millilitres",
                    Alcohol = 40,
                    HexaColor = "#FFFFFF"
                }
            );

            IngredientCollection.Add
            (
                new IngredientModel
                {
                    Id = 10,
                    Name = "Lemon juice",
                    Quantity = 15,
                    QuantityUnit = "millilitres",
                    Alcohol = 0,
                    HexaColor = "#FFFFFF"
                }
            );

            IngredientCollection.Add
            (
                new IngredientModel
                {
                    Id = 11,
                    Name = "Ginger",
                    Quantity = 2,
                    QuantityUnit = "grams",
                    Alcohol = 0,
                    HexaColor = ""
                }
            );

            return IngredientCollection;
        }
    }
}