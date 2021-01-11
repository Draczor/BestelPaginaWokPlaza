using System;
using System.Collections.Generic;
using System.Text;
using Interface;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UserDAL : IUserDAL
    {
        private readonly SqlCommand cmd = new SqlCommand();
        public bool login(UserDTO userDTO)
        {
            Connection connection = new Connection();

            using (SqlConnection sqlcon = connection.con)
            {
                sqlcon.Open();
                cmd.CommandText = @"SELECT * FROM [User] WHERE email = @email AND password = @password";
                cmd.Parameters.AddWithValue("@email", userDTO.email);
                cmd.Parameters.AddWithValue("@password", userDTO.password);
                cmd.Connection = sqlcon;
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        } 
    }
}
