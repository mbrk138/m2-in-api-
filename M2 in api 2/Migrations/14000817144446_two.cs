using Microsoft.EntityFrameworkCore.Migrations;

namespace M2_in_api_2.Migrations
{
    public partial class two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_categories_Product_inproductsID",
                table: "categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_products",
                table: "products",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_categories_products_inproductsID",
                table: "categories",
                column: "inproductsID",
                principalTable: "products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_categories_products_inproductsID",
                table: "categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_products",
                table: "products");

            migrationBuilder.RenameTable(
                name: "products",
                newName: "Product");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_categories_Product_inproductsID",
                table: "categories",
                column: "inproductsID",
                principalTable: "Product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
