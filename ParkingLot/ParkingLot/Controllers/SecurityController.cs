using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehicleManager.Security;
using VehicleModel;

namespace ParkingLot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        public ISecurityManager manager;
        public SecurityController(ISecurityManager manager)
        {
            this.manager = manager;
        }

        [Route("GetLotSpace")]
        [HttpGet]
        public string GetLotSpace()
        {
            return this.manager.GetLotSpace();
        }

        public IEnumerable<Vehicle> GetAllVehicle()
        {
            return this.manager.GetAllVehicle();
        }

        [Route("AddParking")]
        [HttpPost]
        public async Task<IActionResult> AddParking(Vehicle vehicle)
        {
            var result = await this.manager.AddParking(vehicle);
            if (result == 1)
            {
                return this.Ok(vehicle);
            }
            else
            {
                return this.BadRequest();
            }
        }

        [Route("GetVehicle")]
        [HttpGet]
        public async Task<IActionResult> GetVehicle(int ParkinfSlotNumber)
        {
            Vehicle vehicle = this.manager.GetVehicle(ParkinfSlotNumber);

            if (vehicle == null)
            {
                return this.NotFound("The Vehicle record couldn't be found.");
            }

            return this.Ok(vehicle);
        }

        [Route("ParkingCharge")]
        [HttpGet]
        public double ParkingCharges(int ParkinfSlotNumber)
        {
            return this.manager.ParkingCharge(ParkinfSlotNumber);
        }


        [Route("RemoveParking")]
        [HttpDelete]
        public Vehicle RemoveParking(int ParkinfSlotNumber)
        {
            return this.manager.RemoveParking(ParkinfSlotNumber);
        }
    }
}