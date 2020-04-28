using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehicleModel;
using VehicleRepository.Police;

namespace VehicleManager.Police
{
   public class ImpPoliceManager : IPoliceManager
    {
        private readonly IPoliceRepository repo;
        public ImpPoliceManager(IPoliceRepository repo)
        {
            this.repo = repo;
        }

        public Task<int> AddParking(Vehicle vehicle)
        {
            return this.repo.AddParking(vehicle);
        }

        public IEnumerable<Vehicle> GetAllVehicle()
        {
            return this.repo.GetAllVehicle();
        }

        public string GetLotSpace()
        {
            return this.repo.GetLotSpace();
        }

        public Vehicle GetVehicle(int ParkinfSlotNumber)
        {
            return this.repo.GetVehicle(ParkinfSlotNumber);
        }

        public double ParkingCharge(int ParkinfSlotNumber)
        {
            return this.repo.ParkingCharge(ParkinfSlotNumber);
        }

        public Vehicle RemoveParking(int ParkinfSlotNumber)
        {
            return this.repo.RemoveParking(ParkinfSlotNumber);
        }
    }
}
