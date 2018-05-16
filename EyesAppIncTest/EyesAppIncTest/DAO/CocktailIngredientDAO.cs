using EyesAppIncTest.DAO.Comum;
using EyesAppIncTest.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EyesAppIncTest.DAO
{
    public class CocktailIngredientDAO
    {
        public int InsertNewGeneratedCocktail(IngredientModel ingredientModel, int cocktailId)
        {
            dynamic id = 0;

            string query = "insert into [EyesAppIncTest.DB.Context].[dbo].[CocktailIngredients] " +
                                          "(CocktailId, IngredientId) " +
                                          "values " +
                                          "(@CocktailId, @IngredientId) ";

            using (SqlConnection connection = Connection.createConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CocktailId", cocktailId);
                command.Parameters.AddWithValue("@IngredientId", ingredientModel.Id);

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