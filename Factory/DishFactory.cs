using DAL;
using Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class DishFactory
    {
        public static IDishCollectionDAL CreateDishCollectionDAL()
        {
            return new DishDAL();
        }
        
        public static IDishDAL CreateDishDAL()
        {
            return new DishDAL();
        }
    }
}
