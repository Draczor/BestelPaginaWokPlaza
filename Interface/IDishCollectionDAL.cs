using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public interface IDishCollectionDAL
    {
        void getDishList();
        void addDish(DishDTO dishDTO);
        void deleteDish();
    }
}
