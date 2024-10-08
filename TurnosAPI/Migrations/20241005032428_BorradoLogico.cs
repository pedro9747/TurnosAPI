using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TurnosAPI.Migrations
{
    /// <inheritdoc />
    public partial class BorradoLogico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "borrado",
                table: "T_SERVICIOS",
                type: "bit",
                nullable: false,
                defaultValue: false);
            migrationBuilder.AddColumn<string>(
                name: "motivo",
                table: "T_SERVICIOS",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_DETALLES_TURNO_id_servicio",
                table: "T_DETALLES_TURNO",
                column: "id_servicio");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_DETALLES_TURNO");

            migrationBuilder.DropTable(
                name: "T_SERVICIOS");

            migrationBuilder.DropTable(
                name: "T_TURNOS");
        }
    }
}
