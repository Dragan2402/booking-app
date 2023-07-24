using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Authentication.Infrastructure.Migrations
{
    public partial class AddedRolePermission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "RoleId",
                table: "Identities",
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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("162613b2-aa55-498c-9819-c01caaa4ecca"), "Admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("936176c2-95bb-4a2c-a2b9-fa657a02973f"), "Owner" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("b18e34d1-690c-4e41-83a7-43b68df56912"), "Client" });

            migrationBuilder.UpdateData(
                table: "Identities",
                keyColumn: "Id",
                keyValue: new Guid("233275cd-158e-442c-90c1-3bc3495563c6"),
                column: "RoleId",
                value: new Guid("b18e34d1-690c-4e41-83a7-43b68df56912"));

            migrationBuilder.UpdateData(
                table: "Identities",
                keyColumn: "Id",
                keyValue: new Guid("a669b80b-1031-4ef4-985c-112fb99e9cee"),
                column: "RoleId",
                value: new Guid("b18e34d1-690c-4e41-83a7-43b68df56912"));

            migrationBuilder.UpdateData(
                table: "Identities",
                keyColumn: "Id",
                keyValue: new Guid("af8fe996-588b-4056-97f4-9206d56e3fbe"),
                column: "RoleId",
                value: new Guid("936176c2-95bb-4a2c-a2b9-fa657a02973f"));

            migrationBuilder.UpdateData(
                table: "Identities",
                keyColumn: "Id",
                keyValue: new Guid("e91a2f4a-4783-46e8-be53-c9b631e2a8f8"),
                column: "RoleId",
                value: new Guid("936176c2-95bb-4a2c-a2b9-fa657a02973f"));

            migrationBuilder.CreateIndex(
                name: "IX_Identities_RoleId",
                table: "Identities",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionRole_RolesId",
                table: "PermissionRole",
                column: "RolesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Identities_Roles_RoleId",
                table: "Identities",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Identities_Roles_RoleId",
                table: "Identities");

            migrationBuilder.DropTable(
                name: "PermissionRole");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Identities_RoleId",
                table: "Identities");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Identities");
        }
    }
}
