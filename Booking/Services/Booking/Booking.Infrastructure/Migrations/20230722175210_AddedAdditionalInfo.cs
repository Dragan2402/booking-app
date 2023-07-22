using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Infrastructure.Migrations
{
    public partial class AddedAdditionalInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Fee",
                table: "Reservations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "SpecialRequest",
                table: "Reservations",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "TotalPrice",
                table: "Reservations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "WithDiscount",
                table: "Reservations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "TotalPrice",
                table: "Offers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: new Guid("089a9b2a-b844-498c-8797-1a1812c9b504"),
                column: "TotalPrice",
                value: 200.0);

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: new Guid("6b44e9d5-ca61-4c91-95d7-4bd0eb730981"),
                column: "TotalPrice",
                value: 500.0);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("2dabf974-45ba-4db7-99cb-2737a3fcaedf"),
                columns: new[] { "Fee", "SpecialRequest", "TotalPrice" },
                values: new object[] { 20.0, "Bbq if possible", 400.0 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("8d15c6a0-ec48-4e08-a391-865f27fd7dce"),
                columns: new[] { "Fee", "SpecialRequest", "TotalPrice", "WithDiscount" },
                values: new object[] { 10.0, "", 330.0, true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fee",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "SpecialRequest",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "WithDiscount",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Offers");
        }
    }
}
