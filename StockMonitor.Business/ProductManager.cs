using System;
using System.Collections.Generic;
using StockMonitor.DataAccess;
using StockMonitor.Entities;
using StockMonitor.Business.ValidationRules;
using System.Xml.XPath;

namespace StockMonitor.Business
{
    public class ProductManager
    {
        IProductDal _productDal;

        public ProductManager()
        {
            _productDal = new ProductDal();
        }

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
            ProductValidator productValidator = new ProductValidator();
            var result = productValidator.Validate(product);
            if (result.IsValid == false)
            {
                throw new Exception(result.Errors[0].ErrorMessage);
            }

            _productDal.Add(product);
        }

        public void Delete(int id)
        {
            _productDal.Delete(id);
        }

        public void Update(Product product)
        {
            ProductValidator productValidator = new ProductValidator();
            var result = productValidator.Validate(product);

            if (result.IsValid == false)
            {
                throw new Exception(result.Errors[0].ErrorMessage);
            }

            _productDal.Update(product);
        }

        public List<Product> GetProductsByName(string key)
        {
            return _productDal.GetProductsByName(key);
        }

       public int GetProductCount()
        {
            return _productDal.GetProductCount();
        }

        public decimal GetTotalAmount()
        {
            return _productDal.GetTotalAmount();
        }
    }
}
