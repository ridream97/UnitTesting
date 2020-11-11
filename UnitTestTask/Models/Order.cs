using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitTestTask.Models
{
    public class Order
    {
        public string Product { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public Client Customer { get; set; }
    }
}