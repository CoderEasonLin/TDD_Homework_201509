using System.Collections.Generic;

namespace day1homework
{
    public interface IOrderDao
    {
        List<Order> GetOrders();
    }
}