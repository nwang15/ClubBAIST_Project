using Microsoft.EntityFrameworkCore.Migrations;

namespace GolfBAIST_Project.Data.Migrations
{
    public partial class UpdateAspNetUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MemberApplications",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApplicationId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MemberApplications_Id",
                table: "MemberApplications",
                column: "Id",
                unique: true,
                filter: "[Id] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_MemberApplications_AspNetUsers_Id",
                table: "MemberApplications",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberApplications_AspNetUsers_Id",
                table: "MemberApplications");

            migrationBuilder.DropIndex(
                name: "IX_MemberApplications_Id",
                table: "MemberApplications");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MemberApplications");

            migrationBuilder.DropColumn(
                name: "ApplicationId",
                table: "AspNetUsers");
        }
    }
}
