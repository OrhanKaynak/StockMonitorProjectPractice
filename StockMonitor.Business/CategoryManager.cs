using System.Collections.Generic;
using StockMonitor.DataAccess;
using StockMonitor.Entities;

namespace StockMonitor.Business
{
    public class CategoryManager
    {
        CategoryDal _categoryDal = new CategoryDal();

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}
