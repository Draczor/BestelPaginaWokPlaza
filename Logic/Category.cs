using System;
using System.Collections.Generic;
using System.Text;
using Interface;
using Factory;

namespace Logic
{
    public class Category
    {
        private readonly ICategoryDAL _CategoryDAL;
        public Category()
        {
            _CategoryDAL = DALFactory.CreateCategoryDAL();
        }
        
        public void addCategory(CategoryDTO category)
        {
            _CategoryDAL.addCategory(category);
        }

        public List<CategoryDTO> getCategory()
        {
            return _CategoryDAL.getCategory();
        }
    }
}
