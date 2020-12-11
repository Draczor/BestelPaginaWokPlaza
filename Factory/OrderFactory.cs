using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Interface;

namespace Factory
{
    public class OrderFactory
    {
        public static IOrderDAL CreateOrderDAL()
        {
            return new OrderDAL();
        }
    }
}
