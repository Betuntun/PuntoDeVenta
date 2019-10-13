using Microsoft.EntityFrameworkCore.Migrations;

namespace PuntoDeVenta.Migrations
{
    public partial class agregarIdUserToClientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Clientes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ApplicationUserId",
                table: "Clientes",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_AspNetUsers_ApplicationUserId",
                table: "Clientes",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_AspNetUsers_ApplicationUserId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_ApplicationUserId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Clientes");
        }
    }
}
