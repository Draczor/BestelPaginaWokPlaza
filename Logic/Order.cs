using Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Factory;

namespace Logic
{
    public class Order
    {
        private readonly IOrderDAL _OrderDAL;
        public Order()
        {
            _OrderDAL = OrderFactory.CreateOrderDAL();
        }

        public void placeOrder(OrderDTO orderDTO)
        {
            _OrderDAL.placeOrder(orderDTO);
        }
    }
}
