using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class catparthead : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Headings_Categories_CategoryID",
                table: "Headings");

            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Headings_HeadingID",
                table: "Parts");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Parts_PartID",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "PartID",
                table: "Products",
                newName: "HeadingID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_PartID",
                table: "Products",
                newName: "IX_Products_HeadingID");

            migrationBuilder.RenameColumn(
                name: "HeadingID",
                table: "Parts",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Parts_HeadingID",
                table: "Parts",
                newName: "IX_Parts_CategoryID");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Headings",
                newName: "PartID");

            migrationBuilder.RenameIndex(
                name: "IX_Headings_CategoryID",
                table: "Headings",
                newName: "IX_Headings_PartID");

            migrationBuilder.AddForeignKey(
                name: "FK_Headings_Parts_PartID",
                table: "Headings",
                column: "PartID",
                principalTable: "Parts",
                principalColumn: "PartID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Categories_CategoryID",
                table: "Parts",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Headings_HeadingID",
                table: "Products",
                column: "HeadingID",
                principalTable: "Headings",
                principalColumn: "HeadingID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Headings_Parts_PartID",
                table: "Headings");

            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Categories_CategoryID",
                table: "Parts");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Headings_HeadingID",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "HeadingID",
                table: "Products",
                newName: "PartID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_HeadingID",
                table: "Products",
                newName: "IX_Products_PartID");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Parts",
                newName: "HeadingID");

            migrationBuilder.RenameIndex(
                name: "IX_Parts_CategoryID",
                table: "Parts",
                newName: "IX_Parts_HeadingID");

            migrationBuilder.RenameColumn(
                name: "PartID",
                table: "Headings",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Headings_PartID",
                table: "Headings",
                newName: "IX_Headings_CategoryID");

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
    }
}
