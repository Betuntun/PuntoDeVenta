using Microsoft.EntityFrameworkCore.Migrations;

namespace PuntoDeVenta.Migrations
{
    public partial class agregueBienElId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_AspNetUsers_ApplicationUserId",
                table: "Categorias");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_AspNetUsers_ApplicationUserId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_AspNetUsers_ApplicationUserId",
                table: "Ventas");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Ventas",
                newName: "ApplicationUserID");

            migrationBuilder.RenameIndex(
                name: "IX_Ventas_ApplicationUserId",
                table: "Ventas",
                newName: "IX_Ventas_ApplicationUserID");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Clientes",
                newName: "ApplicationUserID");

            migrationBuilder.RenameIndex(
                name: "IX_Clientes_ApplicationUserId",
                table: "Clientes",
                newName: "IX_Clientes_ApplicationUserID");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Categorias",
                newName: "ApplicationUserID");

            migrationBuilder.RenameIndex(
                name: "IX_Categorias_ApplicationUserId",
                table: "Categorias",
                newName: "IX_Categorias_ApplicationUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorias_AspNetUsers_ApplicationUserID",
                table: "Categorias",
                column: "ApplicationUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_AspNetUsers_ApplicationUserID",
                table: "Clientes",
                column: "ApplicationUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_AspNetUsers_ApplicationUserID",
                table: "Ventas",
                column: "ApplicationUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_AspNetUsers_ApplicationUserID",
                table: "Categorias");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_AspNetUsers_ApplicationUserID",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_AspNetUsers_ApplicationUserID",
                table: "Ventas");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserID",
                table: "Ventas",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Ventas_ApplicationUserID",
                table: "Ventas",
                newName: "IX_Ventas_ApplicationUserId");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserID",
                table: "Clientes",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Clientes_ApplicationUserID",
                table: "Clientes",
                newName: "IX_Clientes_ApplicationUserId");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserID",
                table: "Categorias",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Categorias_ApplicationUserID",
                table: "Categorias",
                newName: "IX_Categorias_ApplicationUserId");

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
                name: "FK_Ventas_AspNetUsers_ApplicationUserId",
                table: "Ventas",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
