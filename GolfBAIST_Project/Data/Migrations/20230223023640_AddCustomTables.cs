using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GolfBAIST_Project.Data.Migrations
{
    public partial class AddCustomTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MemberApplications",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MembershipType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberProvince = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberDOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyProvince = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberSignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberSignDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstShareholderFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstShareholderSignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstShareholderSignDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SecondShareholderFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondShareholderSignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondShareholderSignDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberApplications", x => x.ApplicationId);
                });

            migrationBuilder.CreateTable(
                name: "MembersInfos",
                columns: table => new
                {
                    MemberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    MemberFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberLastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembersInfos", x => x.MemberId);
                    table.ForeignKey(
                        name: "FK_MembersInfos_MemberApplications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "MemberApplications",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    reservationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Players = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservations_MembersInfos_MemberId",
                        column: x => x.MemberId,
                        principalTable: "MembersInfos",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MembersInfos_ApplicationId",
                table: "MembersInfos",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_MemberId",
                table: "Reservations",
                column: "MemberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "MembersInfos");

            migrationBuilder.DropTable(
                name: "MemberApplications");
        }
    }
}
