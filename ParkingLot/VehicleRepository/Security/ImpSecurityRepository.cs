using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleModel;

namespace VehicleRepository.Security
{
   public class ImpSecurityRepository : ISecurityRepository
    {
        private readonly VehicleDBContext vehicleDBContext;
        public static int listCapacity = 0;
        public static List<Vehicle> vehicleList = new List<Vehicle>();
        public static List<Vehicle> securityVehicleList = new List<Vehicle>();
        public ImpSecurityRepository(VehicleDBContext vehicleDBContext)
        {
            this.vehicleDBContext = vehicleDBContext;
        }

        public string AddParking(Vehicle vehicle)
        {
            try
            {
                string slotResult = GetLotSpace();
                if (slotResult == "Security lot is full")
                {
                    throw new ParkingLotException("LotNotFound");
                }
                else
                {
                    vehicleDBContext.Vehicle.Add(vehicle);
                    var result = vehicleDBContext.SaveChangesAsync();
                    return vehicle.DriverID.ToString();
                }
            }
            catch(ParkingLotException ex)
            {
                return ex.Msg;
            }
            
        }

        public string GetLotSpace()
        {
            string finalResult = "";
            vehicleList = vehicleDBContext.Vehicle.ToList();
            if (vehicleList.Count != 0)
            {
                for (int i = 0; i < vehicleList.Count; i++)
                {
                    if (vehicleList[i].DriverType == "security" || vehicleList[i].DriverType == "Security")
                    {
                        listCapacity++;
                        securityVehicleList.Add(vehicleList[i]);
                    }
                }
                if (listCapacity == 20)
                    finalResult = "Security lot is full";
               else if (listCapacity == 0)
                    finalResult = "Security Lot is Empty";
               else if (listCapacity > 0)
                {
                    int slotNumber = 1;
                    int index = 0;
                    while (index < securityVehicleList.Count)
                    {
                        bool result = false;
                        for (int i = 0; i < securityVehicleList.Count; i++)
                        {
                            if (slotNumber == securityVehicleList[i].ParkingSlotNumber)
                            {
                                result = true;
                                break;
                            }
                        }
                        if (result == false)
                            break;
                        index++;
                        slotNumber++;
                    }
                    finalResult = slotNumber.ToString();
                }
            }
            else if (vehicleList.Count == 0)
            {
                finalResult = "Parking Slot Is Empty";
            }
            return finalResult;
        }

        public Vehicle GetVehicle(int DriverID)
        {
            return vehicleDBContext.Vehicle.Find(DriverID);
        }

        public double ParkingCharge(int DriverID)
        {
            Vehicle vehicle = vehicleDBContext.Vehicle.Find(DriverID);
            DateTime entry = vehicle.EnteryTime;
            DateTime exit = DateTime.Now;
            double totalHour = (entry - exit).TotalHours;
            if (vehicle.ParkingType.Equals("own", StringComparison.InvariantCultureIgnoreCase)
                && vehicle.DriverType.Equals("security", StringComparison.InvariantCultureIgnoreCase))
            {
                if (totalHour < 1)
                {
                    return 10.0;
                }
                if (vehicle.VehicleType.Equals("twowheeler", StringComparison.InvariantCultureIgnoreCase) && totalHour >= 1)
                {
                    return totalHour * 10;
                }
                else if (vehicle.VehicleType.Equals("fourwheeler", StringComparison.InvariantCultureIgnoreCase) && totalHour >= 1)
                {
                    return totalHour * 20;
                }
            }
            return 0.0;
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

        public IEnumerable<Vehicle> GetAllVehicle()
        {
            return vehicleDBContext.Vehicle;
        }
    }
}
