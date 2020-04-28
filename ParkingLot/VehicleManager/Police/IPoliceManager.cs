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
        Task<int> AddParking(Vehicle vehicle);
        Vehicle GetVehicle(int ParkinfSlotNumber);
        Vehicle RemoveParking(int ParkinfSlotNumber);
        double ParkingCharge(int ParkinfSlotNumber);
    }
}