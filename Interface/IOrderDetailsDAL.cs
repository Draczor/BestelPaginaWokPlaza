﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public interface IOrderDetailsDAL
    {
        void insertOrderDetails(OrderDetailsDTO orderDetailsDTO);
        List<OrderDetailsAndDishDTO> returnDishAndOrderDetailsByOrderIDList(int id);
    }
}
