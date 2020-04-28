using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehicleModel;
using VehicleRepository.Driver;

namespace VehicleManager.Driver
{
  public interface IDriverManager
    {
        string GetLotSpace();
        IEnumerable<Vehicle> GetAllVehicle();
        Task<int> AddParking(Vehicle vehicle);
        Vehicle GetVehicle(int ParkinfSlotNumber);
        Vehicle RemoveParking(int ParkinfSlotNumber);
        double ParkingCharge(int ParkinfSlotNumber);
    }
}
