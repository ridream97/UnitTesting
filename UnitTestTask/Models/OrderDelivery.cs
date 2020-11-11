using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnitTestTask.Interfaces;

namespace UnitTestTask.Models
{
    public class OrderDelivery : IOrderDelivery
    {
        public OrderStatus DeliverOrder(OrderStatus orderStatus)
        {
            if (orderStatus.State.Equals(State.InWork))
            {
                orderStatus.State = State.Delivered;
                return orderStatus;
            }
            else return orderStatus;
        }
    }
}