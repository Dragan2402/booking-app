﻿// <auto-generated />
using System;
using Booking.Services.Authentication.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Authentication.Infrastructure.Migrations
{
    [DbContext(typeof(AuthenticationContext))]
    [Migration("20230720200559_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Booking.Services.Authentication.Domain.Models.Identity", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset(2)");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset(2)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTimeOffset?>("LastLoginAt")
                        .HasColumnType("datetimeoffset(2)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset(2)");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"), false);

                    b.HasIndex("Email", "Id")
                        .IsUnique();

                    SqlServerIndexBuilderExtensions.IsClustered(b.HasIndex("Email", "Id"));

                    b.ToTable("Identities", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("233275cd-158e-442c-90c1-3bc3495563c6"),
                            CreatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "jova@mail.com",
                            UpdatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("a669b80b-1031-4ef4-985c-112fb99e9cee"),
                            CreatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "pero@mail.com",
                            UpdatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("af8fe996-588b-4056-97f4-9206d56e3fbe"),
                            CreatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "gazda@mail.com",
                            UpdatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("e91a2f4a-4783-46e8-be53-c9b631e2a8f8"),
                            CreatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "andrej@mail.com",
                            UpdatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("Booking.Services.Authentication.Domain.Models.PasswordCredentials", b =>
                {
                    b.Property<Guid>("IdentityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset(2)");

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasColumnType("binary(64)");

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("varbinary(20)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset(2)");

                    b.HasKey("IdentityId");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdentityId"));

                    b.ToTable("PasswordCredentials", (string)null);
                });

            modelBuilder.Entity("Booking.Services.Authentication.Domain.Models.PasswordCredentials", b =>
                {
                    b.HasOne("Booking.Services.Authentication.Domain.Models.Identity", null)
                        .WithOne("Credentials")
                        .HasForeignKey("Booking.Services.Authentication.Domain.Models.PasswordCredentials", "IdentityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Booking.Services.Authentication.Domain.Models.Identity", b =>
                {
                    b.Navigation("Credentials");
                });
#pragma warning restore 612, 618
        }
    }
}
