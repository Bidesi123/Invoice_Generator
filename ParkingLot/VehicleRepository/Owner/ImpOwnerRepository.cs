using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehicleModel;

namespace VehicleRepository.Owner
{
   public class ImpOwnerRepository : IOwnerRepository
    {
        private readonly VehicleDBContext vehicleDBContext;
        public ImpOwnerRepository(VehicleDBContext vehicleDBContext)
        {
            this.vehicleDBContext = vehicleDBContext;
        }
        public Task<int> AddParking(Vehicle vehicle)
        {
            vehicleDBContext.Vehicle.Add(vehicle);
            var result = vehicleDBContext.SaveChangesAsync();
            return result;
        }

        public Vehicle GetVehicle(int DriverID)
        {
            return vehicleDBContext.Vehicle.Find(DriverID);
        }

        public Vehicle RemoveParking(int DriverID)
        {
            Vehicle vehicle = vehicleDBContext.Vehicle.Find(DriverID);
            if (vehicle != null)
            {
                vehicleDBContext.Vehicle.Remove(vehicle);
                vehicleDBContext.SaveChanges();
            }
            return vehicle;
        }
    }
}
