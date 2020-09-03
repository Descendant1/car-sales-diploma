using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoRiaBg.Infrastructure.Migrations
{
    public partial class init8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "CarAds",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCar",
                table: "CarAds",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CarAds_CarId",
                table: "CarAds",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarAds_Cars_CarId",
                table: "CarAds",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarAds_Cars_CarId",
                table: "CarAds");

            migrationBuilder.DropIndex(
                name: "IX_CarAds_CarId",
                table: "CarAds");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "CarAds");

            migrationBuilder.DropColumn(
                name: "IdCar",
                table: "CarAds");
        }
    }
}
