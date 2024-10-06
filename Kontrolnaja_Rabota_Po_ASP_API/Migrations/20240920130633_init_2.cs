using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kontrolnaja_Rabota_Po_ASP_API.Migrations
{
    /// <inheritdoc />
    public partial class init_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__productInOrderDb__orderDbs_OrderDbId",
                table: "_productInOrderDb");

            migrationBuilder.DropForeignKey(
                name: "FK__productInOrderDb__productsDb_ProductDbId",
                table: "_productInOrderDb");

            migrationBuilder.AlterColumn<int>(
                name: "ProductDbId",
                table: "_productInOrderDb",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OrderDbId",
                table: "_productInOrderDb",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Shiphr",
                table: "_orderDbs",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX__orderDbs_Shiphr",
                table: "_orderDbs",
                column: "Shiphr",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK__productInOrderDb__orderDbs_OrderDbId",
                table: "_productInOrderDb",
                column: "OrderDbId",
                principalTable: "_orderDbs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__productInOrderDb__productsDb_ProductDbId",
                table: "_productInOrderDb",
                column: "ProductDbId",
                principalTable: "_productsDb",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__productInOrderDb__orderDbs_OrderDbId",
                table: "_productInOrderDb");

            migrationBuilder.DropForeignKey(
                name: "FK__productInOrderDb__productsDb_ProductDbId",
                table: "_productInOrderDb");

            migrationBuilder.DropIndex(
                name: "IX__orderDbs_Shiphr",
                table: "_orderDbs");

            migrationBuilder.AlterColumn<int>(
                name: "ProductDbId",
                table: "_productInOrderDb",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderDbId",
                table: "_productInOrderDb",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Shiphr",
                table: "_orderDbs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK__productInOrderDb__orderDbs_OrderDbId",
                table: "_productInOrderDb",
                column: "OrderDbId",
                principalTable: "_orderDbs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__productInOrderDb__productsDb_ProductDbId",
                table: "_productInOrderDb",
                column: "ProductDbId",
                principalTable: "_productsDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
