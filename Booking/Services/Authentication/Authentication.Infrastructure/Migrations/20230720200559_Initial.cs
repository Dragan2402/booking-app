using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Authentication.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Identities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset(2)", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset(2)", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset(2)", nullable: true),
                    LastLoginAt = table.Column<DateTimeOffset>(type: "datetimeoffset(2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identities", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "PasswordCredentials",
                columns: table => new
                {
                    IdentityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Password = table.Column<byte[]>(type: "binary(64)", nullable: false),
                    Salt = table.Column<byte[]>(type: "varbinary(20)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset(2)", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasswordCredentials", x => x.IdentityId)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_PasswordCredentials_Identities_IdentityId",
                        column: x => x.IdentityId,
                        principalTable: "Identities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Identities",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "LastLoginAt", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("233275cd-158e-442c-90c1-3bc3495563c6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "jova@mail.com", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("a669b80b-1031-4ef4-985c-112fb99e9cee"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "pero@mail.com", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("af8fe996-588b-4056-97f4-9206d56e3fbe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "gazda@mail.com", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("e91a2f4a-4783-46e8-be53-c9b631e2a8f8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "andrej@mail.com", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Identities_Email_Id",
                table: "Identities",
                columns: new[] { "Email", "Id" },
                unique: true)
                .Annotation("SqlServer:Clustered", true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PasswordCredentials");

            migrationBuilder.DropTable(
                name: "Identities");
        }
    }
}
