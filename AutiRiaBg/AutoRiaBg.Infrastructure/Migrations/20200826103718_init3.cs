using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoRiaBg.Infrastructure.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalService_CarAds_CarAdId",
                table: "AdditionalService");

            migrationBuilder.DropForeignKey(
                name: "FK_MultimediaDevice_CarAds_CarAdId",
                table: "MultimediaDevice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MultimediaDevice",
                table: "MultimediaDevice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdditionalService",
                table: "AdditionalService");

            migrationBuilder.RenameTable(
                name: "MultimediaDevice",
                newName: "MultimediaDevices");

            migrationBuilder.RenameTable(
                name: "AdditionalService",
                newName: "AdditionalServices");

            migrationBuilder.RenameIndex(
                name: "IX_MultimediaDevice_CarAdId",
                table: "MultimediaDevices",
                newName: "IX_MultimediaDevices_CarAdId");

            migrationBuilder.RenameIndex(
                name: "IX_AdditionalService_CarAdId",
                table: "AdditionalServices",
                newName: "IX_AdditionalServices_CarAdId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MultimediaDevices",
                table: "MultimediaDevices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdditionalServices",
                table: "AdditionalServices",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalServices_CarAds_CarAdId",
                table: "AdditionalServices",
                column: "CarAdId",
                principalTable: "CarAds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MultimediaDevices_CarAds_CarAdId",
                table: "MultimediaDevices",
                column: "CarAdId",
                principalTable: "CarAds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalServices_CarAds_CarAdId",
                table: "AdditionalServices");

            migrationBuilder.DropForeignKey(
                name: "FK_MultimediaDevices_CarAds_CarAdId",
                table: "MultimediaDevices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MultimediaDevices",
                table: "MultimediaDevices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdditionalServices",
                table: "AdditionalServices");

            migrationBuilder.RenameTable(
                name: "MultimediaDevices",
                newName: "MultimediaDevice");

            migrationBuilder.RenameTable(
                name: "AdditionalServices",
                newName: "AdditionalService");

            migrationBuilder.RenameIndex(
                name: "IX_MultimediaDevices_CarAdId",
                table: "MultimediaDevice",
                newName: "IX_MultimediaDevice_CarAdId");

            migrationBuilder.RenameIndex(
                name: "IX_AdditionalServices_CarAdId",
                table: "AdditionalService",
                newName: "IX_AdditionalService_CarAdId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MultimediaDevice",
                table: "MultimediaDevice",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdditionalService",
                table: "AdditionalService",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalService_CarAds_CarAdId",
                table: "AdditionalService",
                column: "CarAdId",
                principalTable: "CarAds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MultimediaDevice_CarAds_CarAdId",
                table: "MultimediaDevice",
                column: "CarAdId",
                principalTable: "CarAds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
