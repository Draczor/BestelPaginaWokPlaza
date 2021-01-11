using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public interface IUserDAL
    {
        bool login(UserDTO userDTO);
    }
}
