using EyesAppIncTest.DAO.Comum;
using EyesAppIncTest.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EyesAppIncTest.DAO
{
    public class CocktailDAO
    {
        public List<CocktailModel> GetCocktailWithParticuarAmountouOfAlcohol(double alcohol)
        {
            List<CocktailModel> returnObject = null;
            string query = "select co.Id as CocktailId, " +
                                                "co.Name as CocktailName, " +
                                                "co.PercentageOfAlcohol, " +
                                                "co.HexadecimalColor, " +
                                                "i.Id as IngredientId, " +
                                                "i.Name as IngredientName, " +
                                                "i.Quantity as IngredientQt, " +
                                                "i.QuantityUnit as IngredienteQtUni, " +
                                                "i.HexaColor, " +
                                                "i.Alcohol " +
                                        "from [EyesAppIncTest.DB.Context].[dbo].[CocktailModels] co " +
                                  " inner join [EyesAppIncTest.DB.Context].[dbo].[CocktailIngredients] ci " +
                                        "on co.id = ci.CocktailId" +
                                   " inner join [EyesAppIncTest.DB.Context].[dbo].[IngredientModels] i " +
                                        "on i.id = ci.IngredientId" +
                                   " where co.PercentageOfAlcohol = @alcohol" +
                                   " order by ci.CocktailId, ci.IngredientId";

            using (SqlConnection connection = Connection.createConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@alcohol", alcohol);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    if (reader.HasRows)
                    {
                        returnObject = new List<CocktailModel>();

                        while (reader.Read())
                        {
                            CocktailModel cocktail = new CocktailModel();
                            cocktail.Id = Convert.ToInt32(reader["CocktailId"]);
                            cocktail.Name = reader["CocktailName"].ToString();
                            cocktail.PercentageOfAlcohol = Convert.ToDouble(reader["PercentageOfAlcohol"]);
                            cocktail.HexadecimalColor = reader["HexadecimalColor"].ToString();

                            IngredientModel ingredient = new IngredientModel();
                            ingredient.Id = Convert.ToInt32(reader["IngredientId"]);
                            ingredient.Name = reader["IngredientName"].ToString();
                            ingredient.Quantity = Convert.ToInt32(reader["IngredientQt"]);
                            ingredient.QuantityUnit = reader["IngredienteQtUni"].ToString();
                            ingredient.HexaColor = reader["HexaColor"].ToString();
                            ingredient.Alcohol = Convert.ToDouble(reader["Alcohol"]);
                            cocktail.OrderIngredient = new List<IngredientModel>();

                            cocktail.OrderIngredient.Add(ingredient);

                            returnObject.Add(cocktail);
                        }
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                    connection.Close();
                }
            }

            return returnObject;
        }

        public int InsertNewGeneratedCocktail(CocktailModel cocktail)
        {
            dynamic id = 0;

            string query = "insert into [EyesAppIncTest.DB.Context].[dbo].[CocktailModels] " +
                                          "(Name, PercentageOfAlcohol, HexadecimalColor) " +
                                          "values " +
                                          "(@Name, @PercentageAlcohol, @HexaColor); " +
                                          "SELECT SCOPE_IDENTITY() ";

            using (SqlConnection connection = Connection.createConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", cocktail.Name);
                command.Parameters.AddWithValue("@PercentageAlcohol", cocktail.PercentageOfAlcohol);
                command.Parameters.AddWithValue("@HexaColor", cocktail.HexadecimalColor);

                connection.Open();
                try
                {
                    id = command.ExecuteScalar();
                }
                finally
                {
                    // Always call Close when done reading.
                    connection.Close();
                }
            }
            return Convert.ToInt32(id);
        }
    }
}