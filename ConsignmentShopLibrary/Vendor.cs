using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commission { get; set; }
        public decimal PaymentDue { get; set; }

        //Set default value, no return type not at all
        public Vendor()
        {
            Commission = 0.5;
        }

        public string Display
        {
            get
            {
                return string.Format("{0}{1} - ${2}", LastName,FirstName, PaymentDue);
            }
        }
    }
}
