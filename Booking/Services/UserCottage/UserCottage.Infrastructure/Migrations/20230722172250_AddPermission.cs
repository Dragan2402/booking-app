using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserCottage.Infrastructure.Migrations
{
    public partial class AddPermission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PermissionValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PermissionRole",
                columns: table => new
                {
                    PermissionsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RolesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionRole", x => new { x.PermissionsId, x.RolesId });
                    table.ForeignKey(
                        name: "FK_PermissionRole_Permissions_PermissionsId",
                        column: x => x.PermissionsId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PermissionRole_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_PermissionRole_RolesId",
                table: "PermissionRole",
                column: "RolesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PermissionRole");

            migrationBuilder.DropTable(
                name: "Permissions");

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59249fab-eec0-435c-9df9-5aba2c082f39"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 727, DateTimeKind.Unspecified).AddTicks(9387), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 727, DateTimeKind.Unspecified).AddTicks(9389), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e10d5fc-600d-49ff-8d1c-ca15872af496"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 727, DateTimeKind.Unspecified).AddTicks(9355), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 727, DateTimeKind.Unspecified).AddTicks(9378), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1829896-9b2a-4e4f-b732-0b2414547802"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 727, DateTimeKind.Unspecified).AddTicks(9402), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 727, DateTimeKind.Unspecified).AddTicks(9405), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fdb5d61d-f6b9-4b0f-8869-4a9bebeb128a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 727, DateTimeKind.Unspecified).AddTicks(9395), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 21, 0, 9, 12, 727, DateTimeKind.Unspecified).AddTicks(9397), new TimeSpan(0, 2, 0, 0, 0)) });
        }
    }
}
