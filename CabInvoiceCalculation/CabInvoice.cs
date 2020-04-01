using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceCalculation
{
   public class CabInvoice
    {
        private  readonly int COST_PER_TIME ;
        private  readonly double MINIMUM_COST_PER_KILOMETER ;
        private  readonly double MINIMUM_FARE ;

        public CabInvoice()
        {
        }
        public CabInvoice(String Fare_Types)
        {
            if(Fare_Types=="Premium")
            {
                COST_PER_TIME = 2;
                MINIMUM_COST_PER_KILOMETER = 15.0d;
                MINIMUM_FARE = 20;
            }
            if(Fare_Types=="Normal")
            {
                COST_PER_TIME = 1;
                MINIMUM_COST_PER_KILOMETER = 10.0d;
                MINIMUM_FARE = 5;
            }
        }
       
        public double CalculateFare(double Distance, double time)
        {
            double TotalFare = Distance * MINIMUM_COST_PER_KILOMETER + time * COST_PER_TIME;
            return Math.Max(TotalFare, MINIMUM_FARE);
        }

        public double totalFare(Rides[] rides,string Ride_Types)
        {
            double TotalFare = 0;
            CabInvoice obj1 = new CabInvoice(Ride_Types);
            foreach (Rides ride in rides)
            {
                TotalFare += obj1.CalculateFare(ride.distance, ride.time);
            }
            return TotalFare;
        }

        public double TotalRides(Rides[] rides)
        {
            return rides.Length;
        }

        public double AverageFareForEachRides(Rides[] rides,string Ride_Types)
        {
            CabInvoice obj = new CabInvoice(Ride_Types);
            double Totalfare = obj.totalFare(rides,Ride_Types);
            double NoOfRides = obj.TotalRides(rides);
            double AvgFare = Totalfare / NoOfRides;
            return AvgFare;
        }
        public double GetInvoiceSummary(Customer User_Id,string Ride_Types)
        {
            double Total_fare = 0;
            foreach (KeyValuePair<Customer, List<Rides>> keyvalues in RideReposetory.RideDictionary)
            {
                CabInvoice obj = new CabInvoice(Ride_Types);
                if (User_Id == keyvalues.Key)
                {
                    Total_fare = obj.totalFare(keyvalues.Value.ToArray(),Ride_Types);
                }
            }
            return Total_fare;
        }


    }
}
