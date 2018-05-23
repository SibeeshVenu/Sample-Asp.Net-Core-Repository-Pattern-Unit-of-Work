﻿// <auto-generated />
using FuelManApi.Service.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace FuelManApi.Service.Core.Migrations
{
    [DbContext(typeof(FuelManContext))]
    [Migration("20180520113809_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FuelManApi.Contracts.Models.Accounts.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsBank");

                    b.Property<bool>("IsCash");

                    b.Property<bool>("IsDebitType");

                    b.Property<int>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("AccountId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("FuelManApi.Contracts.Models.Accounts.AccountTransaction", b =>
                {
                    b.Property<int>("AccountTransactionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccountId");

                    b.Property<decimal>("Amount");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDebitType");

                    b.Property<string>("TransactionNote");

                    b.Property<int>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("AccountTransactionId");

                    b.HasIndex("AccountId");

                    b.ToTable("AccountTransaction");
                });

            modelBuilder.Entity("FuelManApi.Contracts.Models.Auth.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .HasMaxLength(200);

                    b.Property<string>("LastName")
                        .HasMaxLength(200);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber");

                    b.Property<int?>("ProfileImageImageId");

                    b.Property<string>("Token");

                    b.Property<int>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.Property<string>("UserName");

                    b.Property<int>("UserRoleId");

                    b.HasKey("UserId");

                    b.HasIndex("ProfileImageImageId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("FuelManApi.Contracts.Models.Common.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImageUrl");

                    b.Property<string>("UploadedBy");

                    b.HasKey("ImageId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("FuelManApi.Contracts.Models.HR.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("ContactNo");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("CurrentShiftId");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("PumpId");

                    b.Property<int>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("FuelManApi.Contracts.Models.HR.EmployeeSchedule", b =>
                {
                    b.Property<int>("EmployeeScheduleId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("Date");

                    b.Property<int>("EmployeeId");

                    b.Property<int>("ShiftId");

                    b.Property<int>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("EmployeeScheduleId");

                    b.ToTable("EmployeeSchedule");
                });

            modelBuilder.Entity("FuelManApi.Contracts.Models.HR.Shift", b =>
                {
                    b.Property<int>("ShiftId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<TimeSpan>("EndTime");

                    b.Property<int>("PumpId");

                    b.Property<string>("ShiftName");

                    b.Property<TimeSpan>("StartTime");

                    b.Property<int>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("ShiftId");

                    b.ToTable("Shift");
                });

            modelBuilder.Entity("FuelManApi.Contracts.Models.Nozzle.Fuel", b =>
                {
                    b.Property<int>("FuelId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("FuelName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("PumpId");

                    b.Property<int>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("FuelId");

                    b.ToTable("Fuel");
                });

            modelBuilder.Entity("FuelManApi.Contracts.Models.Nozzle.FuelPrice", b =>
                {
                    b.Property<int>("FuelPriceId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("FuelId");

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("PriceDate");

                    b.Property<int>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("FuelPriceId");

                    b.ToTable("FuelPrice");
                });

            modelBuilder.Entity("FuelManApi.Contracts.Models.Nozzle.Nozzle", b =>
                {
                    b.Property<int>("NozzleId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("FuelId");

                    b.Property<string>("NozzleName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("NozzleId");

                    b.ToTable("Nozzle");
                });

            modelBuilder.Entity("FuelManApi.Contracts.Models.Nozzle.NozzleRegister", b =>
                {
                    b.Property<int>("NozzleRegisterId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("EmployeeScheduleId");

                    b.Property<decimal>("EndReading");

                    b.Property<int>("FuelId");

                    b.Property<int>("NozzleId");

                    b.Property<decimal>("StartReading");

                    b.Property<int>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("NozzleRegisterId");

                    b.ToTable("NozzleRegister");
                });

            modelBuilder.Entity("FuelManApi.Contracts.Models.Nozzle.NozzleRegisterTransaction", b =>
                {
                    b.Property<int>("NozzleTransId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Count");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("DenominationId");

                    b.Property<int>("NozzleRegisterId");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<decimal>("Total");

                    b.Property<int>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("NozzleTransId");

                    b.ToTable("NozzleRegisterTransaction");
                });

            modelBuilder.Entity("FuelManApi.Contracts.Models.Accounts.AccountTransaction", b =>
                {
                    b.HasOne("FuelManApi.Contracts.Models.Accounts.Account", "Account")
                        .WithMany("AccountTransactions")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FuelManApi.Contracts.Models.Auth.User", b =>
                {
                    b.HasOne("FuelManApi.Contracts.Models.Common.Image", "ProfileImage")
                        .WithMany()
                        .HasForeignKey("ProfileImageImageId");
                });
#pragma warning restore 612, 618
        }
    }
}
