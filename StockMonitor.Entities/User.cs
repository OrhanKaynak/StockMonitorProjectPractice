using System;
using System.Collections.Generic;
using System.Text;

namespace StockMonitor.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
