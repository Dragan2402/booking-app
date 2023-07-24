using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserCottage.Infrastructure.Migrations
{
    public partial class RemovedRolePermission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "PermissionRole");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "Users",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("17197b81-dd09-487c-b314-dbb879198cbf"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 668, DateTimeKind.Unspecified).AddTicks(9689), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 668, DateTimeKind.Unspecified).AddTicks(9759), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("87ed11ca-6344-41fe-a8e7-0fcdd455da80"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 668, DateTimeKind.Unspecified).AddTicks(9781), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 668, DateTimeKind.Unspecified).AddTicks(9783), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("89772a55-fc5b-4c79-b24c-22c307c4b78f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 668, DateTimeKind.Unspecified).AddTicks(9773), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 668, DateTimeKind.Unspecified).AddTicks(9776), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("a84c15ab-a67c-4447-a30d-0b0d4e10fbc8"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 668, DateTimeKind.Unspecified).AddTicks(9787), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 668, DateTimeKind.Unspecified).AddTicks(9790), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("d4268f91-5bc6-45e4-8246-d7fe59ded27a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 668, DateTimeKind.Unspecified).AddTicks(9816), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 668, DateTimeKind.Unspecified).AddTicks(9819), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ded20aca-37a5-49be-ad10-2a86e4057486"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 668, DateTimeKind.Unspecified).AddTicks(9823), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 668, DateTimeKind.Unspecified).AddTicks(9825), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("f96e8120-3d51-44fc-9620-d842c6402faf"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 668, DateTimeKind.Unspecified).AddTicks(9766), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 668, DateTimeKind.Unspecified).AddTicks(9768), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e5123dfd-6fa4-4c11-b433-a9ef7227de9f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 669, DateTimeKind.Unspecified).AddTicks(2509), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 669, DateTimeKind.Unspecified).AddTicks(2546), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("faa5b05b-010f-4632-b12b-f1a8b8486582"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 669, DateTimeKind.Unspecified).AddTicks(2554), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 669, DateTimeKind.Unspecified).AddTicks(2556), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("177d102d-ccc4-478d-8c25-7eaf7aecb432"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 669, DateTimeKind.Unspecified).AddTicks(8677), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 669, DateTimeKind.Unspecified).AddTicks(8710), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7d345de0-0ca1-4cd3-ac86-97e424f442d1"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 669, DateTimeKind.Unspecified).AddTicks(8720), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 669, DateTimeKind.Unspecified).AddTicks(8723), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59249fab-eec0-435c-9df9-5aba2c082f39"),
                columns: new[] { "CreatedAt", "Picture", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 670, DateTimeKind.Unspecified).AddTicks(1550), new TimeSpan(0, 2, 0, 0, 0)), "url.2", new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 670, DateTimeKind.Unspecified).AddTicks(1552), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e10d5fc-600d-49ff-8d1c-ca15872af496"),
                columns: new[] { "CreatedAt", "Picture", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 670, DateTimeKind.Unspecified).AddTicks(1513), new TimeSpan(0, 2, 0, 0, 0)), "url.1", new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 670, DateTimeKind.Unspecified).AddTicks(1542), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1829896-9b2a-4e4f-b732-0b2414547802"),
                columns: new[] { "CreatedAt", "Picture", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 670, DateTimeKind.Unspecified).AddTicks(1570), new TimeSpan(0, 2, 0, 0, 0)), "url.4", new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 670, DateTimeKind.Unspecified).AddTicks(1572), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fdb5d61d-f6b9-4b0f-8869-4a9bebeb128a"),
                columns: new[] { "CreatedAt", "Picture", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 670, DateTimeKind.Unspecified).AddTicks(1560), new TimeSpan(0, 2, 0, 0, 0)), "url.3", new DateTimeOffset(new DateTime(2023, 7, 24, 12, 39, 55, 670, DateTimeKind.Unspecified).AddTicks(1563), new TimeSpan(0, 2, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Users");

            migrationBuilder.AddColumn<Guid>(
                name: "RoleId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 113, DateTimeKind.Unspecified).AddTicks(2652), new TimeSpan(0, 2, 0, 0, 0)), new Guid("b18e34d1-690c-4e41-83a7-43b68df56912"), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 113, DateTimeKind.Unspecified).AddTicks(2656), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e10d5fc-600d-49ff-8d1c-ca15872af496"),
                columns: new[] { "CreatedAt", "RoleId", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 113, DateTimeKind.Unspecified).AddTicks(2602), new TimeSpan(0, 2, 0, 0, 0)), new Guid("b18e34d1-690c-4e41-83a7-43b68df56912"), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 113, DateTimeKind.Unspecified).AddTicks(2637), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1829896-9b2a-4e4f-b732-0b2414547802"),
                columns: new[] { "CreatedAt", "RoleId", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 113, DateTimeKind.Unspecified).AddTicks(2678), new TimeSpan(0, 2, 0, 0, 0)), new Guid("936176c2-95bb-4a2c-a2b9-fa657a02973f"), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 113, DateTimeKind.Unspecified).AddTicks(2681), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fdb5d61d-f6b9-4b0f-8869-4a9bebeb128a"),
                columns: new[] { "CreatedAt", "RoleId", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 113, DateTimeKind.Unspecified).AddTicks(2666), new TimeSpan(0, 2, 0, 0, 0)), new Guid("936176c2-95bb-4a2c-a2b9-fa657a02973f"), new DateTimeOffset(new DateTime(2023, 7, 22, 19, 43, 38, 113, DateTimeKind.Unspecified).AddTicks(2669), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionRole_RolesId",
                table: "PermissionRole",
                column: "RolesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id");
        }
    }
}
