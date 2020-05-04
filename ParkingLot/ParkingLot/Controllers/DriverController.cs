﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehicleManager.Driver;
using VehicleModel;

namespace ParkingLot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        public readonly IDriverManager manager;
        public DriverController(IDriverManager manager)
        {
            this.manager = manager;
        }
        [Route("GetAllVehicle")]
        [HttpGet]
        public IEnumerable<Vehicle> GetAllVehicle()
        {
            return this.manager.GetAllVehicle();
        }
        [Route("GetLotSpace")]
        [HttpGet]
        public string GetLotSpace()
        {
            return this.manager.GetLotSpace();
        }

        [Route("AddParking")]
        [HttpPost]
        public string AddParking(Vehicle vehicle)
        {
            /*string result = this.manager.AddParking(vehicle);
            if (result != "")
            {
                return this.Ok(vehicle);
            }
            else
            {
                return this.BadRequest();
            }*/
            return this.manager.AddParking(vehicle);
        }

        [Route("GetVehicle")]
        [HttpGet]
        public async Task<IActionResult> GetVehicle(int DriverID)
        {
            Vehicle vehicle =  this.manager.GetVehicle(DriverID);

            if (vehicle == null)
            {
                return this.NotFound("The Vehicle record couldn't be found.");
            }

            return this.Ok(vehicle);
        }

        [Route("ParkingCharge")]
        [HttpGet]
        public double ParkingCharges(int DriverID)
        {
            return this.manager.ParkingCharge(DriverID);
        }

        [Route("RemoveParking")]
        [HttpDelete]
        public Vehicle RemoveParking(int DriverID)
        {
            return this.manager.RemoveParking(DriverID);
        }
    }
}