using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserCottage.Infrastructure.Migrations
{
    public partial class AddedCityCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Addresses");

            migrationBuilder.AddColumn<Guid>(
                name: "CityId",
                table: "Addresses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset(2)", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset(2)", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset(2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset(2)", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset(2)", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset(2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("177d102d-ccc4-478d-8c25-7eaf7aecb432"), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(9031), new TimeSpan(0, 2, 0, 0, 0)), null, "Serbia", new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(9057), new TimeSpan(0, 2, 0, 0, 0)) },
                    { new Guid("7d345de0-0ca1-4cd3-ac86-97e424f442d1"), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(9064), new TimeSpan(0, 2, 0, 0, 0)), null, "Bosnia and Herzegovina", new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(9066), new TimeSpan(0, 2, 0, 0, 0)) }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59249fab-eec0-435c-9df9-5aba2c082f39"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 522, DateTimeKind.Unspecified).AddTicks(1835), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 522, DateTimeKind.Unspecified).AddTicks(1837), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e10d5fc-600d-49ff-8d1c-ca15872af496"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 522, DateTimeKind.Unspecified).AddTicks(1772), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 522, DateTimeKind.Unspecified).AddTicks(1797), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1829896-9b2a-4e4f-b732-0b2414547802"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 522, DateTimeKind.Unspecified).AddTicks(1855), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 522, DateTimeKind.Unspecified).AddTicks(1858), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fdb5d61d-f6b9-4b0f-8869-4a9bebeb128a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 522, DateTimeKind.Unspecified).AddTicks(1845), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 522, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e5123dfd-6fa4-4c11-b433-a9ef7227de9f"), new Guid("177d102d-ccc4-478d-8c25-7eaf7aecb432"), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(4346), new TimeSpan(0, 2, 0, 0, 0)), null, "Novi Sad", new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(4374), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("faa5b05b-010f-4632-b12b-f1a8b8486582"), new Guid("7d345de0-0ca1-4cd3-ac86-97e424f442d1"), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(4380), new TimeSpan(0, 2, 0, 0, 0)), null, "Brcko", new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(4383), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("17197b81-dd09-487c-b314-dbb879198cbf"),
                columns: new[] { "CityId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new Guid("faa5b05b-010f-4632-b12b-f1a8b8486582"), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1400), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1472), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("87ed11ca-6344-41fe-a8e7-0fcdd455da80"),
                columns: new[] { "CityId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new Guid("e5123dfd-6fa4-4c11-b433-a9ef7227de9f"), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1494), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1496), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("89772a55-fc5b-4c79-b24c-22c307c4b78f"),
                columns: new[] { "CityId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new Guid("e5123dfd-6fa4-4c11-b433-a9ef7227de9f"), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1486), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1489), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("a84c15ab-a67c-4447-a30d-0b0d4e10fbc8"),
                columns: new[] { "CityId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new Guid("e5123dfd-6fa4-4c11-b433-a9ef7227de9f"), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1502), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1505), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("d4268f91-5bc6-45e4-8246-d7fe59ded27a"),
                columns: new[] { "CityId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new Guid("e5123dfd-6fa4-4c11-b433-a9ef7227de9f"), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1511), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1514), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ded20aca-37a5-49be-ad10-2a86e4057486"),
                columns: new[] { "CityId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new Guid("e5123dfd-6fa4-4c11-b433-a9ef7227de9f"), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1547), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1550), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("f96e8120-3d51-44fc-9620-d842c6402faf"),
                columns: new[] { "CityId", "CreatedAt", "UpdatedAt" },
                values: new object[] { new Guid("e5123dfd-6fa4-4c11-b433-a9ef7227de9f"), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1478), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1481), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Cities_CityId",
                table: "Addresses",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Cities_CityId",
                table: "Addresses");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Addresses");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Addresses",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Addresses",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Addresses",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("17197b81-dd09-487c-b314-dbb879198cbf"),
                columns: new[] { "City", "Country", "CreatedAt", "State", "UpdatedAt" },
                values: new object[] { "Brcko", "BiH", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8725), new TimeSpan(0, 2, 0, 0, 0)), "Brcko Distrikt", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8778), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("87ed11ca-6344-41fe-a8e7-0fcdd455da80"),
                columns: new[] { "City", "Country", "CreatedAt", "State", "UpdatedAt" },
                values: new object[] { "Novi Sad", "Srbija", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8804), new TimeSpan(0, 2, 0, 0, 0)), "Vojvodina", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8806), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("89772a55-fc5b-4c79-b24c-22c307c4b78f"),
                columns: new[] { "City", "Country", "CreatedAt", "State", "UpdatedAt" },
                values: new object[] { "Novi Sad", "Srbija", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8796), new TimeSpan(0, 2, 0, 0, 0)), "Vojvodina", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8798), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("a84c15ab-a67c-4447-a30d-0b0d4e10fbc8"),
                columns: new[] { "City", "Country", "CreatedAt", "State", "UpdatedAt" },
                values: new object[] { "Novi Sad", "Srbija", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8811), new TimeSpan(0, 2, 0, 0, 0)), "Vojvodina", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8813), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("d4268f91-5bc6-45e4-8246-d7fe59ded27a"),
                columns: new[] { "City", "Country", "CreatedAt", "State", "UpdatedAt" },
                values: new object[] { "Novi Sad", "Srbija", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8819), new TimeSpan(0, 2, 0, 0, 0)), "Vojvodina", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8822), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ded20aca-37a5-49be-ad10-2a86e4057486"),
                columns: new[] { "City", "Country", "CreatedAt", "State", "UpdatedAt" },
                values: new object[] { "Novi Sad", "Srbija", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8826), new TimeSpan(0, 2, 0, 0, 0)), "Vojvodina", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8828), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("f96e8120-3d51-44fc-9620-d842c6402faf"),
                columns: new[] { "City", "Country", "CreatedAt", "State", "UpdatedAt" },
                values: new object[] { "Novi Sad", "Srbija", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8788), new TimeSpan(0, 2, 0, 0, 0)), "Vojvodina", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8792), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59249fab-eec0-435c-9df9-5aba2c082f39"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 222, DateTimeKind.Unspecified).AddTicks(1195), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 222, DateTimeKind.Unspecified).AddTicks(1198), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e10d5fc-600d-49ff-8d1c-ca15872af496"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 222, DateTimeKind.Unspecified).AddTicks(1172), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 222, DateTimeKind.Unspecified).AddTicks(1189), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1829896-9b2a-4e4f-b732-0b2414547802"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 222, DateTimeKind.Unspecified).AddTicks(1213), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 222, DateTimeKind.Unspecified).AddTicks(1216), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fdb5d61d-f6b9-4b0f-8869-4a9bebeb128a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 222, DateTimeKind.Unspecified).AddTicks(1204), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 222, DateTimeKind.Unspecified).AddTicks(1206), new TimeSpan(0, 2, 0, 0, 0)) });
        }
    }
}
