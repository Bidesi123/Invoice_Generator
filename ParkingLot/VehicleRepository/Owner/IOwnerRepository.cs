using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehicleModel;

namespace VehicleRepository.Owner
{
   public interface IOwnerRepository
    {
        Task<int> AddParking(Vehicle vehicle);
        Vehicle GetVehicle(int ParkinfSlotNumber);
        Vehicle RemoveParking(int ParkinfSlotNumber);     
    }
}
