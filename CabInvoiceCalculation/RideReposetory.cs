using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceCalculation
{
   public class RideReposetory
    {
        public static Dictionary<Customer, List<Rides>> RideDictionary = null;
        public RideReposetory()
        {
            RideDictionary = new Dictionary<Customer, List<Rides>>();
        }

        public void AddRide(List<Rides> rides, Customer User_id)
        {
            RideDictionary.Add(User_id, rides);
        }
    }
}
