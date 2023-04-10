using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GolfBAIST_Project.Migrations
{
    public partial class AddScoreTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    ScoreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MembersInfoMemberId = table.Column<int>(type: "int", nullable: false),
                    MemberFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlayScore = table.Column<int>(type: "int", nullable: false),
                    Handicap = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.ScoreID);
                    table.ForeignKey(
                        name: "FK_Scores_MembersInfos_MembersInfoMemberId",
                        column: x => x.MembersInfoMemberId,
                        principalTable: "MembersInfos",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Scores_MembersInfoMemberId",
                table: "Scores",
                column: "MembersInfoMemberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Scores");
        }
    }
}
