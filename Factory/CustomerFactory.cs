﻿using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Interface;

namespace Factory
{
    public class CustomerFactory
    {
        public static ICustomerDAL CreateCustomerDAL()
        {
            return new CustomerDAL();
        }
    }
}
