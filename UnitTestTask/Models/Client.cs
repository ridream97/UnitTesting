using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitTestTask.Models
{
    public class Client
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public int BirthYear { get; set; }
        public int YearsOfLoyalty { get; set; }

        public int CountDiscount()
        {
            if(BirthYear > 2010)
            {
                var age = DateTime.Now.Year - BirthYear;
                return YearsOfLoyalty > 5 ? age + YearsOfLoyalty : age - YearsOfLoyalty;
            }
            return 0;
        }
    }
}