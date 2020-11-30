using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Interface;

namespace DAL
{
    public class DishDAL : IDishDAL, IDishCollectionDAL
    {
        private readonly SqlCommand cmd = new SqlCommand();
        public void addDish(DishDTO dishDTO)
        {
            cmd.CommandText = @"INSERT INTO Dish (name, price, category_id, description) VALUES (@name, @price, @category_id, @description)";
            cmd.Parameters.AddWithValue("@name", dishDTO.name);
            cmd.Parameters.AddWithValue("@price", dishDTO.price);
            cmd.Parameters.AddWithValue("@category_id", dishDTO.category_id);
            cmd.Parameters.AddWithValue("@description", dishDTO.description);

            Connection connection = new Connection();
            connection.ExecuteCommand(cmd);
        }

        public void deleteDish(int id)
        {
            cmd.CommandText = @"DELETE FROM Dish WHERE id=@id";
            cmd.Parameters.AddWithValue("@id", id);

            Connection connection = new Connection();
            connection.ExecuteCommand(cmd);
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

        public DishDTO getDishById(int id)
        {
            Connection connection = new Connection();
            DataTable dtDish = new DataTable();
            DishDTO dishDTO = new DishDTO();

            using (SqlConnection sqlcon = connection.con)
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Dish WHERE id = " + id, sqlcon);
                sqlDa.Fill(dtDish);
            }

            for (int i = 0; i < dtDish.Rows.Count; i++)
            {
                dishDTO.id = Convert.ToInt32(dtDish.Rows[i]["id"]);
                dishDTO.name = dtDish.Rows[i]["name"].ToString();
                dishDTO.price = Convert.ToDecimal(dtDish.Rows[i]["price"]);
                dishDTO.category_id = Convert.ToInt32(dtDish.Rows[i]["category_id"]);
                dishDTO.description = dtDish.Rows[i]["description"].ToString();
            }

            return dishDTO;
        }

        public void updateDish(DishDTO dishDTO)
        {
            cmd.CommandText = @"UPDATE Dish SET 
                name = @name, 
                price = @price, 
                category_id = @category_id, 
                description = @description 
                WHERE id = @id";
            cmd.Parameters.AddWithValue("@name", dishDTO.name);
            cmd.Parameters.AddWithValue("@price", dishDTO.price);
            cmd.Parameters.AddWithValue("@category_id", dishDTO.category_id);
            cmd.Parameters.AddWithValue("@description", dishDTO.description);
            cmd.Parameters.AddWithValue("@id", dishDTO.id);

            Connection connection = new Connection();
            connection.ExecuteCommand(cmd);
        }
    }
}
