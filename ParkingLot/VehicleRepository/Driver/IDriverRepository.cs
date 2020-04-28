using System;
using System.Collections.Generic;
using System.Text;
using VehicleModel;
using System.Threading.Tasks;

namespace VehicleRepository.Driver
{
   public interface IDriverRepository
    {
        string GetLotSpace();
        IEnumerable<Vehicle> GetAllVehicle();
        Task<int> AddParking(Vehicle vehicle);      
        Vehicle GetVehicle(int ParkinfSlotNumber);
        Vehicle RemoveParking(int ParkinfSlotNumber);
        double ParkingCharge(int ParkinfSlotNumber);    
    }
}
