using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public interface IOrderDAL
    {
        int placeOrderAndReturnLastID(OrderDTO orderDTO);

        List<AllOrdersDTO> returnAllOrders();
    }
}
