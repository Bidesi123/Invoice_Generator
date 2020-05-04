using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleModel;

namespace VehicleRepository.Police
{
   public class ImpPoliceRepository : IPoliceRepository
    {
        private readonly VehicleDBContext vehicleDBContext;
        public static int listCapacity = 0;
        public static List<Vehicle> vehicleList = new List<Vehicle>();
        public static List<Vehicle> policeVehicleList = new List<Vehicle>(1);

        public ImpPoliceRepository(VehicleDBContext vehicleDBContext)
        {
            this.vehicleDBContext = vehicleDBContext;
        }
        public string AddParking(Vehicle vehicle)
        {
            try
            {
                string slotResult = GetLotSpace();
                if (slotResult == "Police lot is full")
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
                    if (vehicleList[i].DriverType == "police" || vehicleList[i].DriverType == "Police")
                    {
                        listCapacity++;
                        policeVehicleList.Add(vehicleList[i]);
                    }
                }
                if (listCapacity == policeVehicleList.Capacity)
                    finalResult = "Police lot is full";
               else if (listCapacity == 0)
                    finalResult = "Police Lot is Empty";
               else if (listCapacity > 0)
                {
                    int slotNumber = 1;
                    int index = 0;
                    while (index < policeVehicleList.Count)
                    {
                        bool result = false;
                        for (int i = 0; i < policeVehicleList.Count; i++)
                        {
                            if (slotNumber == policeVehicleList[i].ParkingSlotNumber)
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
                && vehicle.DriverType.Equals("police", StringComparison.InvariantCultureIgnoreCase))
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
