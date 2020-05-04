﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehicleRepository;

namespace VehicleRepository.Migrations
{
    [DbContext(typeof(VehicleDBContext))]
    [Migration("20200501170009_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VehicleModel.Vehicle", b =>
                {
                    b.Property<int>("DriverID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("ChargesPerHr");

                    b.Property<string>("DriverType");

                    b.Property<DateTime>("EnteryTime");

                    b.Property<int>("ParkingSlotNumber");

                    b.Property<string>("ParkingType");

                    b.Property<int>("VehicleNumber");

                    b.Property<string>("VehicleType");

                    b.HasKey("DriverID");

                    b.ToTable("Vehicle");
                });
#pragma warning restore 612, 618
        }
    }
}