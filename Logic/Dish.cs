using System;
using System.Collections.Generic;
using System.Text;
using Factory;
using Interface;

namespace Logic
{
    public class Dish
    {
        private readonly IDishDAL _IDishDAL;
        public Dish()
        {
            _IDishDAL = DishFactory.CreateDishDAL();
        }

        public void updateDish(DishDTO dishDTO)
        {
            _IDishDAL.updateDish(dishDTO);
        }
    }
}
