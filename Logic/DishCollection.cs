using System;
using System.Collections.Generic;
using System.Text;
using Factory;
using Interface;

namespace Logic
{
    public class DishCollection
    {
        private readonly IDishCollectionDAL _DishCollectionDAL;
        public DishCollection()
        {
            _DishCollectionDAL = DishFactory.CreateDishDAL();
        }

        public void addDish(DishDTO dishDTO)
        {
            _DishCollectionDAL.addDish(dishDTO);
        }
    }
}
