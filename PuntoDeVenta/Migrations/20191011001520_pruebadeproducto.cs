using Microsoft.EntityFrameworkCore.Migrations;

namespace PuntoDeVenta.Migrations
{
    public partial class pruebadeproducto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_AspNetUsers_ApplicationUserId",
                table: "Productos");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Productos",
                newName: "ApplicationUserID");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_ApplicationUserId",
                table: "Productos",
                newName: "IX_Productos_ApplicationUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_AspNetUsers_ApplicationUserID",
                table: "Productos",
                column: "ApplicationUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_AspNetUsers_ApplicationUserID",
                table: "Productos");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserID",
                table: "Productos",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_ApplicationUserID",
                table: "Productos",
                newName: "IX_Productos_ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_AspNetUsers_ApplicationUserId",
                table: "Productos",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
