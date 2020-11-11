using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitTestTask.Models
{
    public class OrderStatus
    {
        public int OrderNumber { get; set; }
        public int OrderSum { get; set; }
        public int DeliverySum { get; set; }
        public State State { get; set; }
    }
}