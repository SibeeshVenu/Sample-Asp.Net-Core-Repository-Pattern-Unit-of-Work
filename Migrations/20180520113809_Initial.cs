using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FuelManApi.Service.Core.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    AccountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountName = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsBank = table.Column<bool>(nullable: false),
                    IsCash = table.Column<bool>(nullable: false),
                    IsDebitType = table.Column<bool>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    ContactNo = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CurrentShiftId = table.Column<int>(nullable: false),
                    EmployeeName = table.Column<string>(maxLength: 200, nullable: false),
                    PumpId = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSchedule",
                columns: table => new
                {
                    EmployeeScheduleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false),
                    ShiftId = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSchedule", x => x.EmployeeScheduleId);
                });

            migrationBuilder.CreateTable(
                name: "Fuel",
                columns: table => new
                {
                    FuelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    FuelName = table.Column<string>(maxLength: 200, nullable: false),
                    PumpId = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuel", x => x.FuelId);
                });

            migrationBuilder.CreateTable(
                name: "FuelPrice",
                columns: table => new
                {
                    FuelPriceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    FuelId = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    PriceDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelPrice", x => x.FuelPriceId);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    ImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImageUrl = table.Column<string>(nullable: true),
                    UploadedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.ImageId);
                });

            migrationBuilder.CreateTable(
                name: "Nozzle",
                columns: table => new
                {
                    NozzleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    FuelId = table.Column<int>(nullable: false),
                    NozzleName = table.Column<string>(maxLength: 200, nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nozzle", x => x.NozzleId);
                });

            migrationBuilder.CreateTable(
                name: "NozzleRegister",
                columns: table => new
                {
                    NozzleRegisterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<decimal>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    EmployeeScheduleId = table.Column<int>(nullable: false),
                    EndReading = table.Column<decimal>(nullable: false),
                    FuelId = table.Column<int>(nullable: false),
                    NozzleId = table.Column<int>(nullable: false),
                    StartReading = table.Column<decimal>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NozzleRegister", x => x.NozzleRegisterId);
                });

            migrationBuilder.CreateTable(
                name: "NozzleRegisterTransaction",
                columns: table => new
                {
                    NozzleTransId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Count = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DenominationId = table.Column<int>(nullable: false),
                    NozzleRegisterId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(maxLength: 500, nullable: false),
                    Total = table.Column<decimal>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NozzleRegisterTransaction", x => x.NozzleTransId);
                });

            migrationBuilder.CreateTable(
                name: "Shift",
                columns: table => new
                {
                    ShiftId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<TimeSpan>(nullable: false),
                    PumpId = table.Column<int>(nullable: false),
                    ShiftName = table.Column<string>(nullable: true),
                    StartTime = table.Column<TimeSpan>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shift", x => x.ShiftId);
                });

            migrationBuilder.CreateTable(
                name: "AccountTransaction",
                columns: table => new
                {
                    AccountTransactionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountId = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsDebitType = table.Column<bool>(nullable: false),
                    TransactionNote = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountTransaction", x => x.AccountTransactionId);
                    table.ForeignKey(
                        name: "FK_AccountTransaction_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(maxLength: 200, nullable: true),
                    LastName = table.Column<string>(maxLength: 200, nullable: true),
                    Password = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    ProfileImageImageId = table.Column<int>(nullable: true),
                    Token = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    UserRoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_Image_ProfileImageImageId",
                        column: x => x.ProfileImageImageId,
                        principalTable: "Image",
                        principalColumn: "ImageId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountTransaction_AccountId",
                table: "AccountTransaction",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_User_ProfileImageImageId",
                table: "User",
                column: "ProfileImageImageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountTransaction");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "EmployeeSchedule");

            migrationBuilder.DropTable(
                name: "Fuel");

            migrationBuilder.DropTable(
                name: "FuelPrice");

            migrationBuilder.DropTable(
                name: "Nozzle");

            migrationBuilder.DropTable(
                name: "NozzleRegister");

            migrationBuilder.DropTable(
                name: "NozzleRegisterTransaction");

            migrationBuilder.DropTable(
                name: "Shift");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Image");
        }
    }
}
