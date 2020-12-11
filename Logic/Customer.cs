using System;
using System.Collections.Generic;
using System.Text;
using Interface;
using Factory;


namespace Logic
{
    public class Customer
    {
        private readonly ICustomerDAL _CustomerDAL;
        public Customer()
        {
            _CustomerDAL = CustomerFactory.CreateCustomerDAL();
        }

        public int addCustommer(CustomerDTO customer)
        {
            return _CustomerDAL.addCustomerAndReturnID(customer);
        }
    }
}
