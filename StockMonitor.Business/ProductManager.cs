using System;
using System.Collections.Generic;
using StockMonitor.DataAccess;
using StockMonitor.Entities;

namespace StockMonitor.Business
{
    public class ProductManager
    {
        ProductDal _productDal = new ProductDal();

        public List<Product> GetAll()
        {

            try
            {
                return _productDal.GetAll();
            }
            catch (Exception ex)
            {

                throw new Exception("Beklenmeyen bir hata oluştu: " + ex.Message);
            }
        }
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(int id)
        {
            _productDal.Delete(id);
        }
    }
}
