using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public interface ICustomerDAL
    {
        int addCustomerAndReturnLastID(CustomerDTO customerDTO);
    }
}
