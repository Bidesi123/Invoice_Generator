using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceCalculation
{
   public class Invoice_Summery
    {
        public int Number_Rides { get; set; }

        public Invoice_Summery(int Number_Rides)
        {
            this.Number_Rides = Number_Rides;
        }

        public static int GetRides(Customer User_Id)
        {
            foreach (KeyValuePair<Customer, List<Rides>> keyvalues in RideReposetory.RideDictionary)
            {
                if (User_Id == keyvalues.Key)
                {
                    return keyvalues.Value.Count;
                }
            }
            return 0;
        }
    }
}
