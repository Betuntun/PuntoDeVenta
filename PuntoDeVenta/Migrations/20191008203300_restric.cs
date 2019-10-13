using Microsoft.EntityFrameworkCore.Migrations;

namespace PuntoDeVenta.Migrations
{
    public partial class restric : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_AspNetUsers_ApplicationUserId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_AspNetUsers_ApplicationUserId",
                table: "Productos");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Ventas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Categorias",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_ApplicationUserId",
                table: "Ventas",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_ApplicationUserId",
                table: "Categorias",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorias_AspNetUsers_ApplicationUserId",
                table: "Categorias",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_AspNetUsers_ApplicationUserId",
                table: "Clientes",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_AspNetUsers_ApplicationUserId",
                table: "Productos",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_AspNetUsers_ApplicationUserId",
                table: "Ventas",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_AspNetUsers_ApplicationUserId",
                table: "Categorias");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_AspNetUsers_ApplicationUserId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_AspNetUsers_ApplicationUserId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_AspNetUsers_ApplicationUserId",
                table: "Ventas");

            migrationBuilder.DropIndex(
                name: "IX_Ventas_ApplicationUserId",
                table: "Ventas");

            migrationBuilder.DropIndex(
                name: "IX_Categorias_ApplicationUserId",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Categorias");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_AspNetUsers_ApplicationUserId",
                table: "Clientes",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_AspNetUsers_ApplicationUserId",
                table: "Productos",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
