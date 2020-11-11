using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnitTestTask.Interfaces;
using UnitTestTask.Models;

namespace UnitTestTask.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;
        private readonly IOrderDelivery orderDelivery;
        public OrderController(IOrderService orderService, IOrderDelivery orderDelivery)
        {
            this.orderService = orderService;
            this.orderDelivery = orderDelivery;
        }
        [HttpGet]
        public OrderStatus DeliverOrder(OrderStatus orderStatus)
        {
            return orderDelivery.DeliverOrder(orderStatus);
        }
        [HttpPost]
        public OrderStatus PrepairOrder(Order order)
        {
            return orderService.PrepairOrder(order);
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}