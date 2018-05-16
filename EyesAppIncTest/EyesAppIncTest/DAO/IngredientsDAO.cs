using EyesAppIncTest.DAO.Comum;
using EyesAppIncTest.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EyesAppIncTest.DAO
{
    public class IngredientsDAO
    {
        public List<IngredientModel> ListAll()
        {
            List<IngredientModel> returnObject = null;
            string query = string.Format("select * " +
                                        "from [EyesAppIncTest.DB.Context].[dbo].[IngredientModels]");

            using (SqlConnection connection = Connection.createConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    if (reader.HasRows)
                    {
                        returnObject = new List<IngredientModel>();

                        while (reader.Read())
                        {
                            IngredientModel ingredient = new IngredientModel();
                            ingredient.Id = Convert.ToInt32(reader["Id"]);
                            ingredient.Name = reader["Name"].ToString();
                            ingredient.Quantity = Convert.ToInt32(reader["Quantity"]);
                            ingredient.QuantityUnit = reader["QuantityUnit"].ToString();
                            ingredient.HexaColor = reader["HexaColor"].ToString();
                            ingredient.Alcohol = Convert.ToDouble(reader["Alcohol"]);
                            returnObject.Add(ingredient);
                        }
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }

            return returnObject;
        }
    }
}