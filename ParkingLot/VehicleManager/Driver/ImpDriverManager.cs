﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehicleModel;
using VehicleRepository.Driver;

namespace VehicleManager.Driver
{
   public class ImpDriverManager : IDriverManager
    {
        private readonly IDriverRepository repo;
        public ImpDriverManager(IDriverRepository repo)
        {
            this.repo = repo;
        }

        public string AddParking(Vehicle vehicle)
        {
            return this.repo.AddParking(vehicle);
        }

        public IEnumerable<Vehicle> GetAllVehicle()
        {
            return this.repo.GetAllVehicle();
        }

        public string GetLotSpace()
        {
            return this.repo.GetLotSpace();
        }

        public Vehicle GetVehicle(int DriverID)
        {
            return this.repo.GetVehicle(DriverID);
        }

        public double ParkingCharge(int DriverID)
        {
            return this.repo.ParkingCharge(DriverID);
        }

        public Vehicle RemoveParking(int DriverID)
        {
            return this.repo.RemoveParking(DriverID);
        }
    }
}
