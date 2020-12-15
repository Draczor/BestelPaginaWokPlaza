using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Interface;

namespace DAL
{
    public class OrderDAL : IOrderDAL, IOrderDetailsDAL
    {
        private readonly SqlCommand cmd = new SqlCommand();

        public void getOrderDetails()
        {
            throw new NotImplementedException();
        }

        public int placeOrderAndReturnLastID(OrderDTO orderDTO)
        {
            cmd.CommandText = @"INSERT INTO [Order] (customer_id, total_price, payment_option, status, delivery_time, remarks, dateTime) VALUES (@customer_id, @total_price, @payment_option, @status, @delivery_time, @remarks, @dateTime) SELECT SCOPE_IDENTITY() AS lastID";
            cmd.Parameters.AddWithValue("@customer_id", orderDTO.customer_id);
            cmd.Parameters.AddWithValue("@total_price", orderDTO.total_price);
            cmd.Parameters.AddWithValue("@payment_option", orderDTO.payment_option);
            cmd.Parameters.AddWithValue("@status", orderDTO.status);
            cmd.Parameters.AddWithValue("@delivery_time", orderDTO.delivery_time);
            cmd.Parameters.AddWithValue("@remarks", orderDTO.remarks);
            cmd.Parameters.AddWithValue("@dateTime", orderDTO.dateTime);

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

        public void insertOrderDetails(OrderDetailsDTO orderDetailsDTO)
        {
            cmd.CommandText = @"INSERT INTO OrderDetails (dish_id, order_id, quantity) VALUES (@dish_id, @order_id, @quantity)";
            cmd.Parameters.AddWithValue("@dish_id", orderDetailsDTO.dish_id);
            cmd.Parameters.AddWithValue("@order_id", orderDetailsDTO.order_id);
            cmd.Parameters.AddWithValue("@quantity", orderDetailsDTO.quantity);

            Connection connection = new Connection();
            connection.ExecuteCommand(cmd);
        }
    }
}
