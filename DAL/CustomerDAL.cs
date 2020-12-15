using System;
using System.Collections.Generic;
using System.Text;
using Interface;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class CustomerDAL : ICustomerDAL
    {
        private readonly SqlCommand cmd = new SqlCommand();

        public int addCustomerAndReturnLastID(CustomerDTO customerDTO)
        {
            cmd.CommandText = @"INSERT INTO Customer (name, street_housenr, postal_code, place, email, phone_number) VALUES (@name, @street_housenr, @postal_code, @place, @email, @phone_number) SELECT SCOPE_IDENTITY() AS lastID";
            cmd.Parameters.AddWithValue("@name", customerDTO.name);
            cmd.Parameters.AddWithValue("@street_housenr", customerDTO.street_housenr);
            cmd.Parameters.AddWithValue("@postal_code", customerDTO.postal_code);
            cmd.Parameters.AddWithValue("@place", customerDTO.place);
            cmd.Parameters.AddWithValue("@email", customerDTO.email);
            cmd.Parameters.AddWithValue("@phone_number", customerDTO.phone_number);

            int lastID = 0;

            Connection connection = new Connection();
            try
            {
                connection.con.Open();
                cmd.Connection = connection.con;

                lastID = Convert.ToInt32(cmd.ExecuteScalar());

                connection.con.Close();
            }
            catch (Exception ex)
            {
                Console.Write("An error has occurred: " + ex.Message);
                connection.con.Close();
            }

            return lastID;
        }

        public List<DishDTO> getDishList()
        {
            Connection connection = new Connection();
            DataTable dtDish = new DataTable();
            List<DishDTO> dishList = new List<DishDTO>();

            using (SqlConnection sqlcon = connection.con)
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Dish", sqlcon);
                sqlDa.Fill(dtDish);
            }

            for (int i = 0; i < dtDish.Rows.Count; i++)
            {
                DishDTO dishDTO = new DishDTO();
                dishDTO.id = Convert.ToInt32(dtDish.Rows[i]["id"]);
                dishDTO.name = dtDish.Rows[i]["name"].ToString();
                dishDTO.price = Convert.ToDecimal(dtDish.Rows[i]["price"]);
                dishDTO.category_id = Convert.ToInt32(dtDish.Rows[i]["category_id"]);
                dishDTO.description = dtDish.Rows[i]["description"].ToString();

                dishList.Add(dishDTO);
            }

            return dishList;
        }
    }
}
