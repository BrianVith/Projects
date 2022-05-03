using Microsoft.EntityFrameworkCore.Migrations;

namespace SurfsUpIdentity.Migrations
{
    public partial class ReviewWithoutRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "SpotReview");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "SpotReview",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
