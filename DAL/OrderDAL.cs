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

        public void placeOrder(OrderDTO orderDTO)
        {
            cmd.CommandText = @"INSERT INTO [Order] (customer_id, total_price, payment_option, status, delivery_time, remarks, dateTime) VALUES (@customer_id, @total_price, @payment_option, @status, @delivery_time, @remarks, @dateTime)";
            cmd.Parameters.AddWithValue("@customer_id", orderDTO.customer_id);
            cmd.Parameters.AddWithValue("@total_price", orderDTO.total_price);
            cmd.Parameters.AddWithValue("@payment_option", orderDTO.payment_option);
            cmd.Parameters.AddWithValue("@status", orderDTO.status);
            cmd.Parameters.AddWithValue("@delivery_time", orderDTO.delivery_time);
            cmd.Parameters.AddWithValue("@remarks", orderDTO.remarks);
            cmd.Parameters.AddWithValue("@dateTime", orderDTO.dateTime);

            Connection connection = new Connection();
            connection.ExecuteCommand(cmd);
        }

        public void setDishList()
        {
            throw new NotImplementedException();
        }
    }
}
