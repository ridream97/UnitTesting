using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestTask.Models;

namespace UnitTestTask.Interfaces
{
    public interface IOrderDelivery
    {
        OrderStatus DeliverOrder(OrderStatus orderStatus);
    }
}
