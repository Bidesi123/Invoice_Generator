using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicleRepository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    ParkinfSlotNumber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VehicleNumber = table.Column<int>(nullable: false),
                    EnteryTime = table.Column<DateTime>(nullable: false),
                    ExitTime = table.Column<DateTime>(nullable: false),
                    chargesPerHr = table.Column<double>(nullable: false),
                    parkingType = table.Column<string>(nullable: true),
                    vehicleType = table.Column<string>(nullable: true),
                    driverType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.ParkinfSlotNumber);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicle");
        }
    }
}
