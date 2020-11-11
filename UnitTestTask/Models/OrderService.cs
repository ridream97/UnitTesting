using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnitTestTask.Interfaces;

namespace UnitTestTask.Models
{
    public class OrderService : IOrderService
    {
        private readonly IDeliveryCalculator deliveryCalculator;
        public int OrderSum { get; set; }

        public OrderService(IDeliveryCalculator deliveryCalculator)
        {
            this.deliveryCalculator = deliveryCalculator;
        }

        public OrderStatus PrepairOrder(Order order)
        {
            OrderSum = order.Count * order.Price;

            return new OrderStatus()
            {
                OrderSum = OrderSum,
                DeliverySum = deliveryCalculator.CalculateDelivery(OrderSum),
                OrderNumber = 1,
                State = State.InWork
            };
        }
    }
}