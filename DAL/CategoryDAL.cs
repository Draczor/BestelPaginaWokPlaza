using System;
using System.Collections.Generic;
using System.Data;
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

        public List<CategoryDTO> getCategory()
        {
            Connection connection = new Connection();
            DataTable dtCategory = new DataTable();
            List<CategoryDTO> categoriesList = new List<CategoryDTO>();

            using (SqlConnection sqlcon = connection.con)
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Category", sqlcon);
                sqlDa.Fill(dtCategory);
            }

            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                CategoryDTO categoryDTO = new CategoryDTO();
                categoryDTO.id = Convert.ToInt32(dtCategory.Rows[i]["id"]);
                categoryDTO.category_name = dtCategory.Rows[i]["category_name"].ToString();

                categoriesList.Add(categoryDTO);
            }

            return categoriesList;
        }
    }
}
