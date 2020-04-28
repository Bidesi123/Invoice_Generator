using System;
using System.Collections.Generic;
using System.Text;
using VehicleModel;
using System.Threading.Tasks;

namespace VehicleRepository.Driver
{
   public class ImpDriverRepository : IDriverRepository
    {
        private readonly VehicleDBContext vehicleDBContext;
        public static List<Vehicle> vehicleList= new List<Vehicle>(20);
        public ImpDriverRepository(VehicleDBContext vehicleDBContext)
        {
            this.vehicleDBContext = vehicleDBContext;
        }

        public string GetLotSpace()
        {
            int index = 0;
            while(index<vehicleList.Count || vehicleList[index]!=null)
            {
                index++;
            }
            if (index == vehicleList.Count)
                return "lot is full";

            return "lot is available";         
        }
        

        public Task<int> AddParking(Vehicle vehicle)
        {
            vehicleDBContext.Vehicle.Add(vehicle);
            var result = vehicleDBContext.SaveChangesAsync();
            vehicleList.Add(vehicle);
            return result;
       
        }

        public Vehicle GetVehicle(int ParkinfSlotNumber)
        {
            return vehicleDBContext.Vehicle.Find(ParkinfSlotNumber);
        }

        public double ParkingCharge(int ParkinfSlotNumber)
        {
            Vehicle vehicle = vehicleDBContext.Vehicle.Find(ParkinfSlotNumber);
            DateTime entry = vehicle.EnteryTime;
            DateTime exit = DateTime.Now;
            double totalHour = (entry - exit).TotalHours;
            if(vehicle.parkingType.Equals("vallet",StringComparison.InvariantCultureIgnoreCase)
                && vehicle.driverType.Equals("PH", StringComparison.InvariantCultureIgnoreCase))
            {
                return totalHour * 0;
            }
            else if(vehicle.parkingType.Equals("own", StringComparison.InvariantCultureIgnoreCase)
                && vehicle.driverType.Equals("normal", StringComparison.InvariantCultureIgnoreCase))
            {
                if(totalHour <1)
                {
                    return 20.0;
                }
                if(vehicle.vehicleType.Equals("twowheeler", StringComparison.InvariantCultureIgnoreCase) && totalHour>=1)
                {
                    return totalHour * vehicle.chargesPerHr;
                }
                else if(vehicle.vehicleType.Equals("fourwheeler", StringComparison.InvariantCultureIgnoreCase) && totalHour>=1)
                {
                    return totalHour * vehicle.chargesPerHr;
                }
            }
            return 0.0;
        }

        public Vehicle RemoveParking(int ParkinfSlotNumber)
        {
            Vehicle vehicle = vehicleDBContext.Vehicle.Find(ParkinfSlotNumber);
            if(vehicle!=null)
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
