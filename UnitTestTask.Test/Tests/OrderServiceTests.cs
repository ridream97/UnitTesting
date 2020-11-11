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
    public class OrderServiceTests
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
        public void PrepairOrder_Test()
        {
            var order = new Order()
            {
                Customer = new Client(),
                Product = "Test Product",
                Count = 1,
                Price = 100
            };
            var orderStatus = orderService.PrepairOrder(order);
            Assert.AreEqual(State.InWork.ToString(), orderStatus.State.ToString());
        }

    }
}
