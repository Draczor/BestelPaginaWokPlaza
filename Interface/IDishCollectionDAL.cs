﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public interface IDishCollectionDAL
    {
        List<DishDTO> getDishList();
        void addDish(DishDTO dishDTO);
        void deleteDish(int id);
        DishDTO getDishById(int id);
    }
}
