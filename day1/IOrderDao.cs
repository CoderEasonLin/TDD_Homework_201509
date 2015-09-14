using System.Collections.Generic;

namespace day1
{
    public interface IOrderDao
    {
        List<Order> GetOrders();
    }
}