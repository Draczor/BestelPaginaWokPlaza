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

        public void deleteDish()
        {
            throw new NotImplementedException();
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
            
            using (SqlConnection sqlcon = connection.con)
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Dish WHERE id = " + id, sqlcon);
                sqlDa.Fill(dtDish);
            }

            DishDTO dishDTO = new DishDTO();
            dishDTO.id = Convert.ToInt32(dtDish.Rows[0]["id"]);
            dishDTO.name = dtDish.Rows[0]["name"].ToString();
            dishDTO.price = Convert.ToDecimal(dtDish.Rows[0]["price"]);
            dishDTO.category_id = Convert.ToInt32(dtDish.Rows[0]["category_id"]);
            dishDTO.description = dtDish.Rows[0]["description"].ToString();

            return dishDTO;
        }

        public void update()
        {
            throw new NotImplementedException();
        }
    }
}
