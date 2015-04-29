using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcumenCodeExercise.Models
{
    public interface IOrdersProvider
    {
        IEnumerable<Order> GetOrders(string country);

        IEnumerable<OrderProductInfo> GetProductPositionInfo(int orderId);

        Order GetOrder(int orderId);
    }
}
