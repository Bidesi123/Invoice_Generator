using System;
using System.Collections.Generic;
using System.Text;
using VehicleModel;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Data.SqlClient;
using System.Linq;

namespace VehicleRepository.Driver
{
   public class ImpDriverRepository : IDriverRepository
   {
        private readonly VehicleDBContext vehicleDBContext;
        public static int listCapacity = 0;
        public static List<Vehicle> vehicleList= new List<Vehicle>();
        public static List<Vehicle> driverVehicleList = new List<Vehicle>(20);

        public ImpDriverRepository(VehicleDBContext vehicleDBContext)
        {
            this.vehicleDBContext = vehicleDBContext;
        }

        public string GetLotSpace()
        {
            string finalResult = "";
            vehicleList = vehicleDBContext.Vehicle.ToList();
            if(vehicleList.Count!=0  )
            {
                for (int i = 0; i < vehicleList.Count; i++)
                {
                    if (vehicleList[i].DriverType == "normal" || vehicleList[i].DriverType == "Normal")
                    {
                        listCapacity++;
                        driverVehicleList.Add(vehicleList[i]);
                    }
                }
                if (listCapacity == driverVehicleList.Capacity || listCapacity> driverVehicleList.Capacity)
                {
                    finalResult = "Driver lot is full";
                }   
                else if (listCapacity == 0)
                    finalResult = "Driver Lot is Empty";
               else if (listCapacity > 0)
                {
                    int slotNumber = 1;
                    int index = 0;
                    while(index<driverVehicleList.Count)
                    {
                        bool result = false;
                        for(int i=0;i<driverVehicleList.Count;i++)
                        {
                            if(slotNumber==driverVehicleList[i].ParkingSlotNumber)
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
                    finalResult= slotNumber.ToString();
                }
            }
            else if(vehicleList.Count==0)
            {
                finalResult= "Parking Slot Is Empty";
            }
            return finalResult;
        }
        
        public string AddParking(Vehicle vehicle)
        {
            try
            {
                string slotResult = GetLotSpace();
                if (slotResult == "Driver lot is full")
                {
                    throw new ParkingLotException("LotNotAvailable");
                }
                else
                {
                    vehicleDBContext.Vehicle.Add(vehicle);
                    var result = vehicleDBContext.SaveChangesAsync();
                    return vehicle.ToString();
                }
            }
            catch(ParkingLotException ex)
            {
                return ex.Msg;
            }
                       
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
            if(vehicle.ParkingType.Equals("vallet",StringComparison.InvariantCultureIgnoreCase)
                && vehicle.DriverType.Equals("PH", StringComparison.InvariantCultureIgnoreCase))
            {
                return totalHour * 0;
            }
            else if(vehicle.ParkingType.Equals("own", StringComparison.InvariantCultureIgnoreCase)
                && vehicle.DriverType.Equals("normal", StringComparison.InvariantCultureIgnoreCase))
                 {
                    if(totalHour <1)
                    {
                        return 20.0;
                    }
                    if(vehicle.VehicleType.Equals("twowheeler", StringComparison.InvariantCultureIgnoreCase) && totalHour>=1)
                    {
                        return totalHour * vehicle.ChargesPerHr;
                    }
                    else if(vehicle.VehicleType.Equals("fourwheeler", StringComparison.InvariantCultureIgnoreCase) && totalHour>=1)
                    {
                        return totalHour * vehicle.ChargesPerHr;
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
