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
            _DishCollectionDAL = DishFactory.CreateDishCollectionDAL();
        }

        public void addDish(DishDTO dishDTO)
        {
            _DishCollectionDAL.addDish(dishDTO);
        }

        public List<DishDTO> getDishList()
        {
            return _DishCollectionDAL.getDishList();
        }

        public DishDTO getDishById(int id)
        {
            return _DishCollectionDAL.getDishById(id);
        }

        public void deleteDish(int id)
        {
            _DishCollectionDAL.deleteDish(id);
        }
    }
}
