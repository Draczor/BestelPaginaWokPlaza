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
        public DishCollection(IDishCollectionDAL iDischCollectionDAL)
        {
            this._DishCollectionDAL = iDischCollectionDAL;
        }

        public void addDish(Dish dish)
        {
            DishDTO dishDTO = new DishDTO
            {
                name = dish.name,
                price = dish.price,
                category_id = dish.category_id,
                description = dish.description
            };

            _DishCollectionDAL.addDish(dishDTO);
        }

        public List<DishDTO> getDishList()
        {
            return _DishCollectionDAL.getDishList();
        }

        public Dish getDishById(int id)
        {
            DishDTO dish =_DishCollectionDAL.getDishById(id);
            if (dish != null)
            {
                return new Dish
                {
                    id = dish.id,
                    name = dish.name,
                    price = dish.price,
                    category_id = dish.category_id,
                    description = dish.description
                };
            }
            return null;
        }

        public void deleteDish(int id)
        {
            _DishCollectionDAL.deleteDish(id);
        }
    }
}
