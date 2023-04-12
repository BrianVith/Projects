using Microsoft.EntityFrameworkCore.Migrations;

namespace SurfsUpIdentity.Migrations
{
    public partial class SpotReviewPropertiesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfPeople",
                table: "SpotReview",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WaveQuality",
                table: "SpotReview",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfPeople",
                table: "SpotReview");

            migrationBuilder.DropColumn(
                name: "WaveQuality",
                table: "SpotReview");
        }
    }
}
