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

        public void getDishList()
        {
            throw new NotImplementedException();
        }

        public void update()
        {
            throw new NotImplementedException();
        }
    }
}
