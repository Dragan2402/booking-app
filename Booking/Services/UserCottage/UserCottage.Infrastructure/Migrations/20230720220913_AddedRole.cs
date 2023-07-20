using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserCottage.Infrastructure.Migrations
{
    public partial class AddedRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserType",
                table: "Users");

            migrationBuilder.AddColumn<Guid>(
                name: "RoleId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("17197b81-dd09-487c-b314-dbb879198cbf"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 726, DateTimeKind.Unspecified).AddTicks(7602), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 726, DateTimeKind.Unspecified).AddTicks(7671), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("87ed11ca-6344-41fe-a8e7-0fcdd455da80"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 726, DateTimeKind.Unspecified).AddTicks(7698), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 726, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("89772a55-fc5b-4c79-b24c-22c307c4b78f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 726, DateTimeKind.Unspecified).AddTicks(7691), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 726, DateTimeKind.Unspecified).AddTicks(7693), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("a84c15ab-a67c-4447-a30d-0b0d4e10fbc8"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 726, DateTimeKind.Unspecified).AddTicks(7704), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 726, DateTimeKind.Unspecified).AddTicks(7707), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("d4268f91-5bc6-45e4-8246-d7fe59ded27a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 726, DateTimeKind.Unspecified).AddTicks(7712), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 726, DateTimeKind.Unspecified).AddTicks(7715), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ded20aca-37a5-49be-ad10-2a86e4057486"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 726, DateTimeKind.Unspecified).AddTicks(7719), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 726, DateTimeKind.Unspecified).AddTicks(7721), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("f96e8120-3d51-44fc-9620-d842c6402faf"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 726, DateTimeKind.Unspecified).AddTicks(7679), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 726, DateTimeKind.Unspecified).AddTicks(7681), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e5123dfd-6fa4-4c11-b433-a9ef7227de9f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 727, DateTimeKind.Unspecified).AddTicks(472), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 727, DateTimeKind.Unspecified).AddTicks(506), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("faa5b05b-010f-4632-b12b-f1a8b8486582"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 727, DateTimeKind.Unspecified).AddTicks(513), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 727, DateTimeKind.Unspecified).AddTicks(516), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("177d102d-ccc4-478d-8c25-7eaf7aecb432"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 727, DateTimeKind.Unspecified).AddTicks(4786), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 727, DateTimeKind.Unspecified).AddTicks(4815), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7d345de0-0ca1-4cd3-ac86-97e424f442d1"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 727, DateTimeKind.Unspecified).AddTicks(4821), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 727, DateTimeKind.Unspecified).AddTicks(4824), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("162613b2-aa55-498c-9819-c01caaa4ecca"), "Admin" },
                    { new Guid("936176c2-95bb-4a2c-a2b9-fa657a02973f"), "Owner" },
                    { new Guid("b18e34d1-690c-4e41-83a7-43b68df56912"), "Client" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59249fab-eec0-435c-9df9-5aba2c082f39"),
                columns: new[] { "CreatedAt", "RoleId", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 727, DateTimeKind.Unspecified).AddTicks(9387), new TimeSpan(0, 2, 0, 0, 0)), new Guid("b18e34d1-690c-4e41-83a7-43b68df56912"), new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 727, DateTimeKind.Unspecified).AddTicks(9389), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e10d5fc-600d-49ff-8d1c-ca15872af496"),
                columns: new[] { "CreatedAt", "RoleId", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 727, DateTimeKind.Unspecified).AddTicks(9355), new TimeSpan(0, 2, 0, 0, 0)), new Guid("b18e34d1-690c-4e41-83a7-43b68df56912"), new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 727, DateTimeKind.Unspecified).AddTicks(9378), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1829896-9b2a-4e4f-b732-0b2414547802"),
                columns: new[] { "CreatedAt", "RoleId", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 727, DateTimeKind.Unspecified).AddTicks(9402), new TimeSpan(0, 2, 0, 0, 0)), new Guid("936176c2-95bb-4a2c-a2b9-fa657a02973f"), new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 727, DateTimeKind.Unspecified).AddTicks(9405), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fdb5d61d-f6b9-4b0f-8869-4a9bebeb128a"),
                columns: new[] { "CreatedAt", "RoleId", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 727, DateTimeKind.Unspecified).AddTicks(9395), new TimeSpan(0, 2, 0, 0, 0)), new Guid("936176c2-95bb-4a2c-a2b9-fa657a02973f"), new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 727, DateTimeKind.Unspecified).AddTicks(9397), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "UserType",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("17197b81-dd09-487c-b314-dbb879198cbf"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1400), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1472), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("87ed11ca-6344-41fe-a8e7-0fcdd455da80"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1494), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1496), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("89772a55-fc5b-4c79-b24c-22c307c4b78f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1486), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1489), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("a84c15ab-a67c-4447-a30d-0b0d4e10fbc8"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1502), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1505), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("d4268f91-5bc6-45e4-8246-d7fe59ded27a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1511), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1514), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ded20aca-37a5-49be-ad10-2a86e4057486"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1547), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1550), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("f96e8120-3d51-44fc-9620-d842c6402faf"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1478), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(1481), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e5123dfd-6fa4-4c11-b433-a9ef7227de9f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(4346), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(4374), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("faa5b05b-010f-4632-b12b-f1a8b8486582"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(4380), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(4383), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("177d102d-ccc4-478d-8c25-7eaf7aecb432"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(9031), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(9057), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7d345de0-0ca1-4cd3-ac86-97e424f442d1"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(9064), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 521, DateTimeKind.Unspecified).AddTicks(9066), new TimeSpan(0, 2, 0, 0, 0)) });

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
                columns: new[] { "CreatedAt", "UpdatedAt", "UserType" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 522, DateTimeKind.Unspecified).AddTicks(1855), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 522, DateTimeKind.Unspecified).AddTicks(1858), new TimeSpan(0, 2, 0, 0, 0)), 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fdb5d61d-f6b9-4b0f-8869-4a9bebeb128a"),
                columns: new[] { "CreatedAt", "UpdatedAt", "UserType" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 522, DateTimeKind.Unspecified).AddTicks(1845), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 20, 22, 39, 11, 522, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 2, 0, 0, 0)), 1 });
        }
    }
}
