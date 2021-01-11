using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Interface;

namespace Factory
{
    public class UserFactory
    {
        public static IUserDAL CreateUserDAL()
        {
            return new UserDAL();
        }
    }
}
