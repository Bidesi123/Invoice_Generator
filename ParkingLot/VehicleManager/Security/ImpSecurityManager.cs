using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehicleModel;
using VehicleRepository.Security;

namespace VehicleManager.Security
{
   public class ImpSecurityManager : ISecurityManager
    {
        private readonly ISecurityRepository repo;
        public ImpSecurityManager(ISecurityRepository repo)
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
