﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public interface IOrderDetailsDAL
    {
        void setDishList();
        void calcTotalPrice();
        void setStatus();
    }
}