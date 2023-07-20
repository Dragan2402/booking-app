using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserCottage.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Street = table.Column<string>(type: "varchar(255)", nullable: false),
                    City = table.Column<string>(type: "varchar(255)", nullable: false),
                    PostalCode = table.Column<string>(type: "varchar(255)", nullable: false),
                    State = table.Column<string>(type: "varchar(255)", nullable: false),
                    Country = table.Column<string>(type: "varchar(255)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset(2)", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset(2)", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset(2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(255)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(255)", nullable: false),
                    IdentityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserType = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset(2)", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset(2)", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset(2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cottages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset(2)", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset(2)", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset(2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cottages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cottages_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cottages_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "CreatedAt", "DeletedAt", "PostalCode", "State", "Street", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("17197b81-dd09-487c-b314-dbb879198cbf"), "Brcko", "BiH", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8725), new TimeSpan(0, 2, 0, 0, 0)), null, "76100", "Brcko Distrikt", "Pavla Savica 42", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8778), new TimeSpan(0, 2, 0, 0, 0)) },
                    { new Guid("87ed11ca-6344-41fe-a8e7-0fcdd455da80"), "Novi Sad", "Srbija", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8804), new TimeSpan(0, 2, 0, 0, 0)), null, "21000", "Vojvodina", "Pavloviceva 11", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8806), new TimeSpan(0, 2, 0, 0, 0)) },
                    { new Guid("89772a55-fc5b-4c79-b24c-22c307c4b78f"), "Novi Sad", "Srbija", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8796), new TimeSpan(0, 2, 0, 0, 0)), null, "21000", "Vojvodina", "Palicka 13", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8798), new TimeSpan(0, 2, 0, 0, 0)) },
                    { new Guid("a84c15ab-a67c-4447-a30d-0b0d4e10fbc8"), "Novi Sad", "Srbija", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8811), new TimeSpan(0, 2, 0, 0, 0)), null, "21000", "Vojvodina", "Futoski put bb", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8813), new TimeSpan(0, 2, 0, 0, 0)) },
                    { new Guid("d4268f91-5bc6-45e4-8246-d7fe59ded27a"), "Novi Sad", "Srbija", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8819), new TimeSpan(0, 2, 0, 0, 0)), null, "21000", "Vojvodina", "Fruska Gora 2121", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8822), new TimeSpan(0, 2, 0, 0, 0)) },
                    { new Guid("ded20aca-37a5-49be-ad10-2a86e4057486"), "Novi Sad", "Srbija", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8826), new TimeSpan(0, 2, 0, 0, 0)), null, "21000", "Vojvodina", "Jovana Popovica 51", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8828), new TimeSpan(0, 2, 0, 0, 0)) },
                    { new Guid("f96e8120-3d51-44fc-9620-d842c6402faf"), "Novi Sad", "Srbija", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8788), new TimeSpan(0, 2, 0, 0, 0)), null, "21000", "Vojvodina", "Svetojovanska 11", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 221, DateTimeKind.Unspecified).AddTicks(8792), new TimeSpan(0, 2, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AddressId", "CreatedAt", "DeletedAt", "FirstName", "IdentityId", "LastName", "UpdatedAt", "UserType" },
                values: new object[,]
                {
                    { new Guid("59249fab-eec0-435c-9df9-5aba2c082f39"), new Guid("89772a55-fc5b-4c79-b24c-22c307c4b78f"), new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 222, DateTimeKind.Unspecified).AddTicks(1195), new TimeSpan(0, 2, 0, 0, 0)), null, "Pero", new Guid("a669b80b-1031-4ef4-985c-112fb99e9cee"), "Peric", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 222, DateTimeKind.Unspecified).AddTicks(1198), new TimeSpan(0, 2, 0, 0, 0)), 0 },
                    { new Guid("8e10d5fc-600d-49ff-8d1c-ca15872af496"), new Guid("17197b81-dd09-487c-b314-dbb879198cbf"), new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 222, DateTimeKind.Unspecified).AddTicks(1172), new TimeSpan(0, 2, 0, 0, 0)), null, "Jovan", new Guid("233275cd-158e-442c-90c1-3bc3495563c6"), "Jovic", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 222, DateTimeKind.Unspecified).AddTicks(1189), new TimeSpan(0, 2, 0, 0, 0)), 0 },
                    { new Guid("a1829896-9b2a-4e4f-b732-0b2414547802"), new Guid("a84c15ab-a67c-4447-a30d-0b0d4e10fbc8"), new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 222, DateTimeKind.Unspecified).AddTicks(1213), new TimeSpan(0, 2, 0, 0, 0)), null, "Andrej", new Guid("e91a2f4a-4783-46e8-be53-c9b631e2a8f8"), "Culjak", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 222, DateTimeKind.Unspecified).AddTicks(1216), new TimeSpan(0, 2, 0, 0, 0)), 1 },
                    { new Guid("fdb5d61d-f6b9-4b0f-8869-4a9bebeb128a"), new Guid("87ed11ca-6344-41fe-a8e7-0fcdd455da80"), new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 222, DateTimeKind.Unspecified).AddTicks(1204), new TimeSpan(0, 2, 0, 0, 0)), null, "Gazda", new Guid("af8fe996-588b-4056-97f4-9206d56e3fbe"), "Gazdic", new DateTimeOffset(new DateTime(2023, 7, 20, 20, 54, 2, 222, DateTimeKind.Unspecified).AddTicks(1206), new TimeSpan(0, 2, 0, 0, 0)), 1 }
                });

            migrationBuilder.InsertData(
                table: "Cottages",
                columns: new[] { "Id", "AddressId", "CreatedAt", "DeletedAt", "Name", "OwnerId", "UpdatedAt" },
                values: new object[] { new Guid("7397fd64-0d58-4322-a743-a81f77c64fd8"), new Guid("d4268f91-5bc6-45e4-8246-d7fe59ded27a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Funny Resort", new Guid("fdb5d61d-f6b9-4b0f-8869-4a9bebeb128a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Cottages",
                columns: new[] { "Id", "AddressId", "CreatedAt", "DeletedAt", "Name", "OwnerId", "UpdatedAt" },
                values: new object[] { new Guid("8e10d5fc-600d-49ff-8d1c-ca15872af896"), new Guid("f96e8120-3d51-44fc-9620-d842c6402faf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Sunshine Bebe", new Guid("fdb5d61d-f6b9-4b0f-8869-4a9bebeb128a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Cottages",
                columns: new[] { "Id", "AddressId", "CreatedAt", "DeletedAt", "Name", "OwnerId", "UpdatedAt" },
                values: new object[] { new Guid("98adc6d2-4b27-486f-9520-9ceda899168c"), new Guid("ded20aca-37a5-49be-ad10-2a86e4057486"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "QSX Mansion", new Guid("a1829896-9b2a-4e4f-b732-0b2414547802"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_Cottages_AddressId",
                table: "Cottages",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cottages_OwnerId",
                table: "Cottages",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AddressId",
                table: "Users",
                column: "AddressId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cottages");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
