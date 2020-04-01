using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceCalculation
{
   public class Customer
    {
        public string User_id { get; set; }
        public Customer(string User_id)
        {
            this.User_id = User_id;
        }
    }
}
