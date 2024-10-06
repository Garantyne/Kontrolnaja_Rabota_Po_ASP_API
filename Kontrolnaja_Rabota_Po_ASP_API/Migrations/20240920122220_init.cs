using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kontrolnaja_Rabota_Po_ASP_API.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_orderDbs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shiphr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfFormation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__orderDbs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_productsDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsPresent = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__productsDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_productInOrderDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDbId = table.Column<int>(type: "int", nullable: false),
                    ProductDbId = table.Column<int>(type: "int", nullable: false),
                    QuantityProductInOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__productInOrderDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK__productInOrderDb__orderDbs_OrderDbId",
                        column: x => x.OrderDbId,
                        principalTable: "_orderDbs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__productInOrderDb__productsDb_ProductDbId",
                        column: x => x.ProductDbId,
                        principalTable: "_productsDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX__productInOrderDb_OrderDbId",
                table: "_productInOrderDb",
                column: "OrderDbId");

            migrationBuilder.CreateIndex(
                name: "IX__productInOrderDb_ProductDbId",
                table: "_productInOrderDb",
                column: "ProductDbId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_productInOrderDb");

            migrationBuilder.DropTable(
                name: "_orderDbs");

            migrationBuilder.DropTable(
                name: "_productsDb");
        }
    }
}
