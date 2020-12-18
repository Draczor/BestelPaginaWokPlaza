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
    }
}
