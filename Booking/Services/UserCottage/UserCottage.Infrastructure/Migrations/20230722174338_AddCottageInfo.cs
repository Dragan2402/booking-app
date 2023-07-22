using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserCottage.Infrastructure.Migrations
{
    public partial class AddCottageInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdditionalInfo",
                table: "Cottages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MaxCapacity",
                table: "Cottages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Pictures",
                table: "Cottages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "PricePerDay",
                table: "Cottages",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "PromoDescription",
                table: "Cottages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Rooms",
                table: "Cottages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("17197b81-dd09-487c-b314-dbb879198cbf"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 111, DateTimeKind.Unspecified).AddTicks(2418), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 111, DateTimeKind.Unspecified).AddTicks(2521), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("87ed11ca-6344-41fe-a8e7-0fcdd455da80"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 111, DateTimeKind.Unspecified).AddTicks(2567), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 111, DateTimeKind.Unspecified).AddTicks(2573), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("89772a55-fc5b-4c79-b24c-22c307c4b78f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 111, DateTimeKind.Unspecified).AddTicks(2553), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 111, DateTimeKind.Unspecified).AddTicks(2558), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("a84c15ab-a67c-4447-a30d-0b0d4e10fbc8"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 111, DateTimeKind.Unspecified).AddTicks(2581), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 111, DateTimeKind.Unspecified).AddTicks(2585), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("d4268f91-5bc6-45e4-8246-d7fe59ded27a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 111, DateTimeKind.Unspecified).AddTicks(2599), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 111, DateTimeKind.Unspecified).AddTicks(2604), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ded20aca-37a5-49be-ad10-2a86e4057486"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 111, DateTimeKind.Unspecified).AddTicks(2613), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 111, DateTimeKind.Unspecified).AddTicks(2618), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("f96e8120-3d51-44fc-9620-d842c6402faf"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 111, DateTimeKind.Unspecified).AddTicks(2536), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 111, DateTimeKind.Unspecified).AddTicks(2542), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e5123dfd-6fa4-4c11-b433-a9ef7227de9f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 111, DateTimeKind.Unspecified).AddTicks(6816), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 111, DateTimeKind.Unspecified).AddTicks(6852), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("faa5b05b-010f-4632-b12b-f1a8b8486582"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 111, DateTimeKind.Unspecified).AddTicks(6869), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 111, DateTimeKind.Unspecified).AddTicks(6875), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Cottages",
                keyColumn: "Id",
                keyValue: new Guid("7397fd64-0d58-4322-a743-a81f77c64fd8"),
                columns: new[] { "AdditionalInfo", "Pictures", "PricePerDay", "PromoDescription" },
                values: new object[] { "Funny cottage.", "picture.url3:picture.url4", 29.0, "Fun fun fun" });

            migrationBuilder.UpdateData(
                table: "Cottages",
                keyColumn: "Id",
                keyValue: new Guid("8e10d5fc-600d-49ff-8d1c-ca15872af896"),
                columns: new[] { "AdditionalInfo", "Pictures", "PricePerDay", "PromoDescription" },
                values: new object[] { "Very cool and roomy cottage.", "picture.url1:picture.url2", 50.0, "Cool cottage" });

            migrationBuilder.UpdateData(
                table: "Cottages",
                keyColumn: "Id",
                keyValue: new Guid("98adc6d2-4b27-486f-9520-9ceda899168c"),
                columns: new[] { "AdditionalInfo", "Pictures", "PricePerDay", "PromoDescription" },
                values: new object[] { "Terrible place with terrible people avoid at all costs.", "picture.url1:picture.url2", 30.0, "Terrible" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("177d102d-ccc4-478d-8c25-7eaf7aecb432"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 112, DateTimeKind.Unspecified).AddTicks(5785), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 112, DateTimeKind.Unspecified).AddTicks(5824), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7d345de0-0ca1-4cd3-ac86-97e424f442d1"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 112, DateTimeKind.Unspecified).AddTicks(5833), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 112, DateTimeKind.Unspecified).AddTicks(5836), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59249fab-eec0-435c-9df9-5aba2c082f39"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 113, DateTimeKind.Unspecified).AddTicks(2652), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 113, DateTimeKind.Unspecified).AddTicks(2656), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e10d5fc-600d-49ff-8d1c-ca15872af496"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 113, DateTimeKind.Unspecified).AddTicks(2602), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 113, DateTimeKind.Unspecified).AddTicks(2637), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1829896-9b2a-4e4f-b732-0b2414547802"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 113, DateTimeKind.Unspecified).AddTicks(2678), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 113, DateTimeKind.Unspecified).AddTicks(2681), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fdb5d61d-f6b9-4b0f-8869-4a9bebeb128a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 113, DateTimeKind.Unspecified).AddTicks(2666), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 113, DateTimeKind.Unspecified).AddTicks(2669), new TimeSpan(0, 2, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdditionalInfo",
                table: "Cottages");

            migrationBuilder.DropColumn(
                name: "MaxCapacity",
                table: "Cottages");

            migrationBuilder.DropColumn(
                name: "Pictures",
                table: "Cottages");

            migrationBuilder.DropColumn(
                name: "PricePerDay",
                table: "Cottages");

            migrationBuilder.DropColumn(
                name: "PromoDescription",
                table: "Cottages");

            migrationBuilder.DropColumn(
                name: "Rooms",
                table: "Cottages");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("17197b81-dd09-487c-b314-dbb879198cbf"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 763, DateTimeKind.Unspecified).AddTicks(8913), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 763, DateTimeKind.Unspecified).AddTicks(8984), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("87ed11ca-6344-41fe-a8e7-0fcdd455da80"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 763, DateTimeKind.Unspecified).AddTicks(9004), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 763, DateTimeKind.Unspecified).AddTicks(9006), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("89772a55-fc5b-4c79-b24c-22c307c4b78f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 763, DateTimeKind.Unspecified).AddTicks(8997), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 763, DateTimeKind.Unspecified).AddTicks(8999), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("a84c15ab-a67c-4447-a30d-0b0d4e10fbc8"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 763, DateTimeKind.Unspecified).AddTicks(9010), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 763, DateTimeKind.Unspecified).AddTicks(9012), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("d4268f91-5bc6-45e4-8246-d7fe59ded27a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 763, DateTimeKind.Unspecified).AddTicks(9018), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 763, DateTimeKind.Unspecified).AddTicks(9020), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ded20aca-37a5-49be-ad10-2a86e4057486"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 763, DateTimeKind.Unspecified).AddTicks(9049), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 763, DateTimeKind.Unspecified).AddTicks(9051), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("f96e8120-3d51-44fc-9620-d842c6402faf"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 763, DateTimeKind.Unspecified).AddTicks(8990), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 763, DateTimeKind.Unspecified).AddTicks(8992), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e5123dfd-6fa4-4c11-b433-a9ef7227de9f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 764, DateTimeKind.Unspecified).AddTicks(1555), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 764, DateTimeKind.Unspecified).AddTicks(1583), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("faa5b05b-010f-4632-b12b-f1a8b8486582"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 764, DateTimeKind.Unspecified).AddTicks(1590), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 764, DateTimeKind.Unspecified).AddTicks(1592), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("177d102d-ccc4-478d-8c25-7eaf7aecb432"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 764, DateTimeKind.Unspecified).AddTicks(5971), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 764, DateTimeKind.Unspecified).AddTicks(5999), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7d345de0-0ca1-4cd3-ac86-97e424f442d1"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 764, DateTimeKind.Unspecified).AddTicks(6005), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 764, DateTimeKind.Unspecified).AddTicks(6007), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59249fab-eec0-435c-9df9-5aba2c082f39"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 765, DateTimeKind.Unspecified).AddTicks(1085), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 765, DateTimeKind.Unspecified).AddTicks(1087), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e10d5fc-600d-49ff-8d1c-ca15872af496"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 765, DateTimeKind.Unspecified).AddTicks(1052), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 765, DateTimeKind.Unspecified).AddTicks(1075), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1829896-9b2a-4e4f-b732-0b2414547802"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 765, DateTimeKind.Unspecified).AddTicks(1104), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 765, DateTimeKind.Unspecified).AddTicks(1107), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fdb5d61d-f6b9-4b0f-8869-4a9bebeb128a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 765, DateTimeKind.Unspecified).AddTicks(1095), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 22, 49, 765, DateTimeKind.Unspecified).AddTicks(1097), new TimeSpan(0, 2, 0, 0, 0)) });
        }
    }
}
