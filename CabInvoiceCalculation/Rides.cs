using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceCalculation
{
   public class Rides
    {
        public double distance;
        public double time;

        public Rides(double distance,double time)
        {
            this.distance = distance;
            this.time = time;
        }
    }
}
