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

        public Order(IOrderDAL iOrderDAL)
        {
            _OrderDAL = iOrderDAL;
        }

        public int placeOrder(OrderDTO orderDTO)
        {
            return _OrderDAL.placeOrderAndReturnLastID(orderDTO);
        }

        public List<AllOrdersDTO> returnAllOrders()
        {
            return _OrderDAL.returnAllOrders();
        }
    }
}
