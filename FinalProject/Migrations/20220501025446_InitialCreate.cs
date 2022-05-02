using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CandidateDetail",
                columns: table => new
                {
                    candidate_id = table.Column<string>(nullable: false),
                    name = table.Column<string>(nullable: false),
                    party = table.Column<string>(nullable: false),
                    candidate_status = table.Column<string>(nullable: false),
                    state = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateDetail", x => x.candidate_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidateDetail");
        }
    }
}
