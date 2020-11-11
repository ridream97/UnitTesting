using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnitTestTask.Interfaces;

namespace UnitTestTask.Models
{
    public class DeliveryCalculator : IDeliveryCalculator
    {
        public int CalculateDelivery(int sum)
        {
            return sum + 50;
        }
    }
}