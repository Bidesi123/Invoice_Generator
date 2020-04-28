using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehicleModel;

namespace VehicleRepository.Security
{
   public class ImpSecurityRepository : ISecurityRepository
    {
        private readonly VehicleDBContext vehicleDBContext;
        public static List<Vehicle> vehicleList = new List<Vehicle>(20);
        public ImpSecurityRepository(VehicleDBContext vehicleDBContext)
        {
            this.vehicleDBContext = vehicleDBContext;
        }

        public Task<int> AddParking(Vehicle vehicle)
        {
            vehicleDBContext.Vehicle.Add(vehicle);
            var result = vehicleDBContext.SaveChangesAsync();
            vehicleList.Add(vehicle);
            return result;
        }

        public string GetLotSpace()
        {
            int index = 0;
            while (index < vehicleList.Count || vehicleList[index] != null)
            {
                index++;
            }
            if (index == vehicleList.Count)
                return "lot is full";

            return "lot is available";
        }

        public Vehicle GetVehicle(int ParkinfSlotNumber)
        {
            return vehicleDBContext.Vehicle.Find(ParkinfSlotNumber);
        }

        public double ParkingCharge(int ParkinfSlotNumber)
        {
            Vehicle vehicle = vehicleDBContext.Vehicle.Find(ParkinfSlotNumber);
            DateTime entry = vehicle.EnteryTime;
            DateTime exit = vehicle.ExitTime;
            double totalHour = (entry - exit).TotalHours;
            if (vehicle.parkingType.Equals("own", StringComparison.InvariantCultureIgnoreCase)
                && vehicle.driverType.Equals("security", StringComparison.InvariantCultureIgnoreCase))
            {
                if (totalHour < 1)
                {
                    return 10.0;
                }
                if (vehicle.vehicleType.Equals("twowheeler", StringComparison.InvariantCultureIgnoreCase) && totalHour >= 1)
                {
                    return totalHour * 10;
                }
                else if (vehicle.vehicleType.Equals("fourwheeler", StringComparison.InvariantCultureIgnoreCase) && totalHour >= 1)
                {
                    return totalHour * 20;
                }
            }
            return 0.0;
        }

        public Vehicle RemoveParking(int ParkinfSlotNumber)
        {
            Vehicle vehicle = vehicleDBContext.Vehicle.Find(ParkinfSlotNumber);
            if (vehicle != null)
            {
                vehicleDBContext.Vehicle.Remove(vehicle);
                vehicleDBContext.SaveChanges();
            }
            vehicleList.Remove(vehicle);
            return vehicle;
        }

        public IEnumerable<Vehicle> GetAllVehicle()
        {
            return vehicleDBContext.Vehicle;
        }
    }
}
