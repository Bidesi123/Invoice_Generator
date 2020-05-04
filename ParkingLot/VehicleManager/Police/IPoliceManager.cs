﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehicleModel;

namespace VehicleManager.Police
{
   public interface IPoliceManager
    {
        string GetLotSpace();
        IEnumerable<Vehicle> GetAllVehicle();
        string AddParking(Vehicle vehicle);
        Vehicle GetVehicle(int DriverID);
        Vehicle RemoveParking(int DriverID);
        double ParkingCharge(int DriverID);
    }
}
