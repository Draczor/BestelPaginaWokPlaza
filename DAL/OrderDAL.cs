using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Interface;

namespace DAL
{
    public class OrderDAL : IOrderDAL, IOrderDetailsDAL
    {
        private readonly SqlCommand cmd = new SqlCommand();

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

        public List<AllOrdersDTO> returnAllOrders()
        {
            Connection connection = new Connection();
            DataTable dtOrders = new DataTable();
            List<AllOrdersDTO> AllOrdersList = new List<AllOrdersDTO>();

            using (SqlConnection sqlcon = connection.con)
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM [Order] INNER JOIN Customer ON[Order].customer_id = Customer.id ORDER BY dateTime DESC", sqlcon);
                sqlDa.Fill(dtOrders);
            }

            for (int i = 0; i < dtOrders.Rows.Count; i++)
            {
                AllOrdersDTO allOrdersDTO = new AllOrdersDTO();
                allOrdersDTO.id = Convert.ToInt32(dtOrders.Rows[i]["id"]);
                allOrdersDTO.customer_id = Convert.ToInt32(dtOrders.Rows[i]["customer_id"]);
                allOrdersDTO.total_price = Convert.ToDecimal(dtOrders.Rows[i]["total_price"]);
                allOrdersDTO.payment_option = dtOrders.Rows[i]["payment_option"].ToString();
                allOrdersDTO.status = dtOrders.Rows[i]["status"].ToString();
                allOrdersDTO.delivery_time = dtOrders.Rows[i]["delivery_time"].ToString();
                allOrdersDTO.remarks = dtOrders.Rows[i]["remarks"].ToString();
                allOrdersDTO.dateTime = Convert.ToDateTime(dtOrders.Rows[i]["dateTime"]);
                allOrdersDTO.name = dtOrders.Rows[i]["name"].ToString();
                allOrdersDTO.street_housenr = dtOrders.Rows[i]["street_housenr"].ToString();
                allOrdersDTO.postal_code = dtOrders.Rows[i]["postal_code"].ToString();
                allOrdersDTO.place = dtOrders.Rows[i]["place"].ToString();
                allOrdersDTO.email = dtOrders.Rows[i]["email"].ToString();
                allOrdersDTO.phone_number = dtOrders.Rows[i]["phone_number"].ToString();

                AllOrdersList.Add(allOrdersDTO);
            }

            return AllOrdersList;
        }
        
        public List<OrderDetailsAndDishDTO> returnDishAndOrderDetailsByOrderIDList(int id)
        {
            Connection connection = new Connection();
            DataTable dtable = new DataTable();
            List<OrderDetailsAndDishDTO> OrderDetailsAndDishList = new List<OrderDetailsAndDishDTO>();

            using (SqlConnection sqlcon = connection.con)
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM OrderDetails INNER JOIN Dish ON OrderDetails.dish_id = dish.id WHERE order_id = " + id, sqlcon);
                sqlDa.Fill(dtable);
            }

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                OrderDetailsAndDishDTO orderDetailsAndDishDTO = new OrderDetailsAndDishDTO();
                orderDetailsAndDishDTO.id = Convert.ToInt32(dtable.Rows[i]["id"]);
                orderDetailsAndDishDTO.dish_id = Convert.ToInt32(dtable.Rows[i]["dish_id"]);
                orderDetailsAndDishDTO.order_id = Convert.ToInt32(dtable.Rows[i]["order_id"]);
                orderDetailsAndDishDTO.quantity = Convert.ToInt32(dtable.Rows[i]["quantity"]);
                orderDetailsAndDishDTO.name = dtable.Rows[i]["name"].ToString();
                orderDetailsAndDishDTO.price = Convert.ToDecimal(dtable.Rows[i]["price"]);
                orderDetailsAndDishDTO.category_id = Convert.ToInt32(dtable.Rows[i]["category_id"]);
                orderDetailsAndDishDTO.description = dtable.Rows[i]["description"].ToString();

                OrderDetailsAndDishList.Add(orderDetailsAndDishDTO);
            }

            return OrderDetailsAndDishList;
        }
    }
}
