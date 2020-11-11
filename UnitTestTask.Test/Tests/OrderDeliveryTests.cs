using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestTask.Interfaces;
using UnitTestTask.Models;

namespace UnitTestTask.Test.Tests
{
    [TestFixture]
    public class OrderDeliveryTests
    {
        private IDeliveryCalculator deliveryCalculator;
        private IOrderService orderService;
        private IOrderDelivery orderDelivery;
        [SetUp]
        public void Initialize()
        {
            deliveryCalculator = new DeliveryCalculator();
            orderService = new OrderService(deliveryCalculator);
            orderDelivery = new OrderDelivery();
        }
        [Test]
        public void DeliverOrder_Test()
        {
            var orderStatus = new OrderStatus()
            {
                State = State.InWork
            };
            var finalOrderStatus = orderDelivery.DeliverOrder(orderStatus);
            Assert.AreEqual(State.Delivered.ToString(), finalOrderStatus.State.ToString());
        } 
        [Test]
        public void DeliverOrderWithPending_Test()
        {
            var orderStatus = new OrderStatus()
            {
                State = State.Pending
            };
            var finalOrderStatus = orderDelivery.DeliverOrder(orderStatus);
            Assert.AreEqual(State.Pending.ToString(), finalOrderStatus.State.ToString());
        }
    }
}
