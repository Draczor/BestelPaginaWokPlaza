using System;
using System.Collections.Generic;
using System.Text;
using Interface;
using Factory;

namespace Logic
{
    public class User
    {
        private readonly IUserDAL _IUserDAL;
        public User()
        {
            _IUserDAL = UserFactory.CreateUserDAL();
        }

        public User(IUserDAL iUserDAL)
        {
            _IUserDAL = iUserDAL;
        }

        public bool login(UserDTO userDTO)
        {
            return _IUserDAL.login(userDTO);
        }
    }
}
