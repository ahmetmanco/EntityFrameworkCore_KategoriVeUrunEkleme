using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _01Store.Migrations
{
    /// <inheritdoc />
    public partial class uc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UrununDükkaniId",
                table: "Urunler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_UrununDükkaniId",
                table: "Urunler",
                column: "UrununDükkaniId");

            migrationBuilder.AddForeignKey(
                name: "FK_Urunler_Dukkanlar_UrununDükkaniId",
                table: "Urunler",
                column: "UrununDükkaniId",
                principalTable: "Dukkanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urunler_Dukkanlar_UrununDükkaniId",
                table: "Urunler");

            migrationBuilder.DropIndex(
                name: "IX_Urunler_UrununDükkaniId",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "UrununDükkaniId",
                table: "Urunler");
        }
    }
}
