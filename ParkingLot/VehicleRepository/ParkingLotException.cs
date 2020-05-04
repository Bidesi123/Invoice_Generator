using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleRepository
{
    public enum Parking
    {
        LOT_NOT_AVAILABLE
    }
    public class ParkingLotException : Exception
    {
        private string message;
        public ParkingLotException(string message) 
        {
            this.message = message;
        }
        public string Msg
        {
            get
            {
                return this.message;
            }
        }
    }
}
