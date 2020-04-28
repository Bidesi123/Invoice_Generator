﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehicleModel;
using VehicleRepository.Owner;

namespace VehicleManager.Owner
{
   public class ImpOwnerManager : IOwnerManager
    {
        private readonly IOwnerRepository repo;
        public ImpOwnerManager(IOwnerRepository repo)
        {
            this.repo = repo;
        }

        public Task<int> AddParking(Vehicle vehicle)
        {
            return this.repo.AddParking(vehicle);
        }

        public Vehicle GetVehicle(int ParkinfSlotNumber)
        {
            return this.repo.GetVehicle(ParkinfSlotNumber);
        }

        public Vehicle RemoveParking(int ParkinfSlotNumber)
        {
            return this.repo.RemoveParking(ParkinfSlotNumber);
        }
    }
}
