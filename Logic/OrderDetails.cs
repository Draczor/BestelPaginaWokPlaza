using Interface;
using Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class OrderDetails
    {
        private readonly IOrderDetailsDAL _OrderDetailsDAL;
        public OrderDetails()
        {
            _OrderDetailsDAL = OrderFactory.CreateOrderDetailsDAL();
        }

        public OrderDetails(IOrderDetailsDAL iOrderDetailsDAL)
        {
            _OrderDetailsDAL = iOrderDetailsDAL;
        }

        public void insertOrderDetails(OrderDetailsDTO orderDetailsDTO)
        {
            _OrderDetailsDAL.insertOrderDetails(orderDetailsDTO);
        }
        
        public List<OrderDetailsAndDishDTO> returnDishAndOrderDetailsByOrderIDList(int id)
        {
            return _OrderDetailsDAL.returnDishAndOrderDetailsByOrderIDList(id);
        }
    }
}
