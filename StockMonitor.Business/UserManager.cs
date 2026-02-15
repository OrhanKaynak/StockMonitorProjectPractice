using StockMonitor.DataAccess;
using StockMonitor.Entities;

namespace StockMonitor.Business
{
    public class UserManager
    {
        UserDal _userDal = new UserDal();

        public bool Login(User user)
        {
            return _userDal.CheckUser(user);
        }
    }
}
