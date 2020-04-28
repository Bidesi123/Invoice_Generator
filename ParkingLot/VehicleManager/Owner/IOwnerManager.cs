using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehicleModel;


namespace VehicleManager.Owner
{
   public interface IOwnerManager
    {
        Task<int> AddParking(Vehicle vehicle);
        Vehicle GetVehicle(int ParkinfSlotNumber);
        Vehicle RemoveParking(int ParkinfSlotNumber);
    }
}
