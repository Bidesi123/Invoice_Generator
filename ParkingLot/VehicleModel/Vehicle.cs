using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VehicleModel
{
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ParkinfSlotNumber { get; set; }
        public int VehicleNumber { get; set; }
        public DateTime EnteryTime { get; set; }
        public DateTime ExitTime { get; set; }
        public double chargesPerHr { get; set; }
        public string parkingType { get; set; }
        public string vehicleType { get; set; }
        public string driverType { get; set; }
    }
}
