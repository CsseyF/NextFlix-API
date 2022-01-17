using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NextflixAPI.Migrations
{
    public partial class MovieParametersAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "movie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Maturity",
                table: "movie",
                type: "varchar(2)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "movie");

            migrationBuilder.DropColumn(
                name: "Maturity",
                table: "movie");
        }
    }
}
