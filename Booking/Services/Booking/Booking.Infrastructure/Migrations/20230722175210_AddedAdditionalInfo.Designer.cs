﻿// <auto-generated />
using System;
using Booking.Services.Booking.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Booking.Infrastructure.Migrations
{
    [DbContext(typeof(BookingContext))]
    [Migration("20230722175210_AddedAdditionalInfo")]
    partial class AddedAdditionalInfo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Booking.Services.Booking.Domain.Offer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CottageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset(2)");

                    b.Property<DateTimeOffset>("DateFrom")
                        .HasColumnType("datetimeoffset(2)");

                    b.Property<DateTimeOffset>("DateTo")
                        .HasColumnType("datetimeoffset(2)");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset(2)");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset(2)");

                    b.HasKey("Id");

                    b.ToTable("Offers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("089a9b2a-b844-498c-8797-1a1812c9b504"),
                            CottageId = new Guid("98adc6d2-4b27-486f-9520-9ceda899168c"),
                            CreatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            DateFrom = new DateTimeOffset(new DateTime(2022, 12, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            DateTo = new DateTimeOffset(new DateTime(2022, 12, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            TotalPrice = 200.0,
                            UpdatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("6b44e9d5-ca61-4c91-95d7-4bd0eb730981"),
                            CottageId = new Guid("7397fd64-0d58-4322-a743-a81f77c64fd8"),
                            CreatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            DateFrom = new DateTimeOffset(new DateTime(2022, 10, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            DateTo = new DateTimeOffset(new DateTime(2022, 10, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            TotalPrice = 500.0,
                            UpdatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("Booking.Services.Booking.Domain.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CottageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset(2)");

                    b.Property<DateTimeOffset>("DateFrom")
                        .HasColumnType("datetimeoffset(2)");

                    b.Property<DateTimeOffset>("DateTo")
                        .HasColumnType("datetimeoffset(2)");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset(2)");

                    b.Property<double>("Fee")
                        .HasColumnType("float");

                    b.Property<string>("SpecialRequest")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset(2)");

                    b.Property<bool>("WithDiscount")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Reservations", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("2dabf974-45ba-4db7-99cb-2737a3fcaedf"),
                            ClientId = new Guid("59249fab-eec0-435c-9df9-5aba2c082f39"),
                            CottageId = new Guid("98adc6d2-4b27-486f-9520-9ceda899168c"),
                            CreatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            DateFrom = new DateTimeOffset(new DateTime(2022, 11, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            DateTo = new DateTimeOffset(new DateTime(2022, 11, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Fee = 20.0,
                            SpecialRequest = "Bbq if possible",
                            TotalPrice = 400.0,
                            UpdatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            WithDiscount = false
                        },
                        new
                        {
                            Id = new Guid("8d15c6a0-ec48-4e08-a391-865f27fd7dce"),
                            ClientId = new Guid("59249fab-eec0-435c-9df9-5aba2c082f39"),
                            CottageId = new Guid("7397fd64-0d58-4322-a743-a81f77c64fd8"),
                            CreatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            DateFrom = new DateTimeOffset(new DateTime(2022, 9, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            DateTo = new DateTimeOffset(new DateTime(2022, 9, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Fee = 10.0,
                            SpecialRequest = "",
                            TotalPrice = 330.0,
                            UpdatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            WithDiscount = true
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
