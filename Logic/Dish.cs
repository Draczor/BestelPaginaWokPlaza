using System;
using System.Collections.Generic;
using System.Text;
using Factory;
using Interface;

namespace Logic
{
    public class Dish
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int category_id { get; set; }
        public string description { get; set; }

        private readonly IDishDAL _IDishDAL;
        public Dish()
        {
            _IDishDAL = DishFactory.CreateDishDAL();
        }

        public Dish(IDishDAL iDishDAL)
        {
            
            this._IDishDAL = iDishDAL;     
        }

        public void updateDish()
        {
            DishDTO dishDTO = new DishDTO 
            {
               id = id,
               name = name,
               price = price,
               category_id = category_id,
               description = description
            };
            _IDishDAL.updateDish(dishDTO);
        }
    }
}
