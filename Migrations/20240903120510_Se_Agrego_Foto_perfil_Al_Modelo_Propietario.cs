using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taller.Migrations
{
    /// <inheritdoc />
    public partial class Se_Agrego_Foto_perfil_Al_Modelo_Propietario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Propietarios",
                type: "varchar(125)",
                maxLength: 125,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Propietarios",
                type: "varchar(125)",
                maxLength: 125,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Correo",
                table: "Propietarios",
                type: "varchar(125)",
                maxLength: 125,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "FotoDePerfil",
                table: "Propietarios",
                type: "varchar(125)",
                maxLength: 125,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FotoDePerfil",
                table: "Propietarios");

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Propietarios",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(125)",
                oldMaxLength: 125)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Propietarios",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(125)",
                oldMaxLength: 125)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Correo",
                table: "Propietarios",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(125)",
                oldMaxLength: 125)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
