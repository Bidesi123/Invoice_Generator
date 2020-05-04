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
        public int DriverID { get; set; }
        [Required]
        public int ParkingSlotNumber { get; set; }
        [Required]
        public int VehicleNumber { get; set; }
        [Required]
        public DateTime EnteryTime { get; set; }
        [Required]
        public double ChargesPerHr { get; set; }
        [Required]
        public string ParkingType { get; set; }
        [Required]
        public string DriverType { get; set; }
        [Required]
        public string VehicleType { get; set; }


        public override string ToString()
        {
            return "DriverID: "+ DriverID+"\n"+ "ParkingSlotNumber: "+ ParkingSlotNumber
                +"\n"+ "VehicleNumber: " + VehicleNumber+"\n"+ "EnteryTime: "+ EnteryTime+"\n"
                + "ChargesPerHr: "+ ChargesPerHr+"\n"+ "ParkingType: "+ ParkingType+"\n"
                + "DriverType: "+ DriverType+"\n"+ "VehicleType: "+ VehicleType;
        }
    }
}
