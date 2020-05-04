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
        string AddParking(Vehicle vehicle);      
        Vehicle GetVehicle(int DriverID);
        Vehicle RemoveParking(int DriverID);
        double ParkingCharge(int DriverID);    
    }
}
