using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehicleManager.Owner;
using VehicleModel;

namespace ParkingLot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        public readonly IOwnerManager manager;
        public OwnerController(IOwnerManager manager)
        {
            this.manager = manager;
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
        public async Task<IActionResult> GetVehicle(int DriverID)
        {
            Vehicle vehicle = this.manager.GetVehicle(DriverID);

            if (vehicle == null)
            {
                return this.NotFound("The Vehicle record couldn't be found.");
            }

            return this.Ok(vehicle);
        }

        [Route("RemoveParking")]
        [HttpDelete]
        public Vehicle RemoveParking(int DriverID)
        {
            return this.manager.RemoveParking(DriverID);
        }
    }
}