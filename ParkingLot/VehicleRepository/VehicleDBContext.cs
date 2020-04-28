using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VehicleModel;

namespace VehicleRepository
{
   public class VehicleDBContext : DbContext
    {
        public VehicleDBContext(DbContextOptions<VehicleDBContext> option) : base(option)
        {

        }
        public DbSet<Vehicle> Vehicle { get; set; }
    }
}
