using StockMonitor.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMonitor.DataAccess
{
    public interface ICategoryDal
    {
        List<Category> GetAll();

    }
}
