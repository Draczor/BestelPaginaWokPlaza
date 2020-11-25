using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Interface;

namespace Factory
{
    public class DALFactory
    {
        public static ICategoryDAL CreateCategoryDAL()
        {
            return new CategoryDAL();
        }

        
    }
}
