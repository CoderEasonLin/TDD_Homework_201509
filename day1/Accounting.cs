using System.Collections.Generic;
using System.Linq;

namespace day1
{
    public class Accounting
    {
        private readonly IOrderDao _OrderDao;

        public Accounting(IOrderDao orderDao)
        {
            _OrderDao = orderDao;
        }

        public List<int> GetCosts()
        {
            var orders = _OrderDao.GetOrders();
            var groupOfCost = orders.GroupBy(x => (x.Id - 1)/3).ToList();
            var costs = groupOfCost.Select(x => x.Sum(y => y.Cost)).ToList();
            return costs;
        }

        public List<int> GetRevenues()
        {
            var orders = _OrderDao.GetOrders();
            var groupOfRevenues = orders.GroupBy(x => (x.Id - 1)/4).ToList();
            var revenues = groupOfRevenues.Select(x => x.Sum(y => y.Revenue)).ToList();
            return revenues;
        }
    }
}