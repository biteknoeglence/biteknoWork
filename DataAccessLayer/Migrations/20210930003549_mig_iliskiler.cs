using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_iliskiler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PartID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HeadingID",
                table: "Parts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Headings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductIC",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_PartID",
                table: "Products",
                column: "PartID");

            migrationBuilder.CreateIndex(
                name: "IX_Parts_HeadingID",
                table: "Parts",
                column: "HeadingID");

            migrationBuilder.CreateIndex(
                name: "IX_Headings_CategoryID",
                table: "Headings",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductID",
                table: "Comments",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Products_ProductID",
                table: "Comments",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Headings_Categories_CategoryID",
                table: "Headings",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Headings_HeadingID",
                table: "Parts",
                column: "HeadingID",
                principalTable: "Headings",
                principalColumn: "HeadingID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Parts_PartID",
                table: "Products",
                column: "PartID",
                principalTable: "Parts",
                principalColumn: "PartID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Products_ProductID",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Headings_Categories_CategoryID",
                table: "Headings");

            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Headings_HeadingID",
                table: "Parts");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Parts_PartID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_PartID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Parts_HeadingID",
                table: "Parts");

            migrationBuilder.DropIndex(
                name: "IX_Headings_CategoryID",
                table: "Headings");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ProductID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "PartID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "HeadingID",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Headings");

            migrationBuilder.DropColumn(
                name: "ProductIC",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Comments");
        }
    }
}
