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

        public int placeOrder(OrderDTO orderDTO)
        {
            return _OrderDAL.placeOrderAndReturnLastID(orderDTO);
        }
    }
}
