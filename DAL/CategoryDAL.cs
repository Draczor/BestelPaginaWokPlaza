using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Interface;

namespace DAL
{
    public class CategoryDAL : ICategoryDAL
    {
        private readonly SqlCommand cmd = new SqlCommand();
        
        public void addCategory(CategoryDTO category)
        {
            cmd.CommandText = @"INSERT INTO Category (category_name) VALUES (@category_name)";
            cmd.Parameters.AddWithValue("@category_name", category.category_name);

            Connection connection = new Connection();
            connection.ExecuteCommand(cmd);
        }
    }
}
