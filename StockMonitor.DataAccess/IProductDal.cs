using System.Collections.Generic;
using StockMonitor.Entities;

namespace StockMonitor.DataAccess
{
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
        List<Product> GetProductsByName(string key);
        int GetProductCount();
        decimal GetTotalAmount();

    }
}
