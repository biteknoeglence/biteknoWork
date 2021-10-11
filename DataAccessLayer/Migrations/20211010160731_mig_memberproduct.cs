using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_memberproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MemberID",
                table: "Products",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_MemberID",
                table: "Products",
                column: "MemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Members_MemberID",
                table: "Products",
                column: "MemberID",
                principalTable: "Members",
                principalColumn: "MemberID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Members_MemberID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_MemberID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MemberID",
                table: "Products");
        }
    }
}
