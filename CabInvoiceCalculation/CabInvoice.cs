using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceCalculation
{
   public class CabInvoice
    {
        private static readonly double fare_Per_kelometer = 10;
        private static readonly double fare_Per_minute = 1;
        private static readonly double min_fare = 5;
         double kelometer;
         double time;
        int totalRides;
        double totalFareAmount;
       
        public CabInvoice(double kelometer,double time)
        {
            this.kelometer = kelometer;
            this.time = time;
        }
       

        public static double Calculate_Fare(double distance,double time)
        {
            double total_Fare = distance * fare_Per_kelometer + time * fare_Per_minute;
            return Math.Max(total_Fare, min_fare);
        }
       
       


    }
}
