using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymApp.Data.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "clientes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastName", "Name" },
                values: new object[] { "Cliente Apellido 1", "Cliente Nombre 1" });

            migrationBuilder.UpdateData(
                table: "clientes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastName", "Name" },
                values: new object[] { "Cliente Apellido 2", "Cliente Nombre 2" });

            migrationBuilder.UpdateData(
                table: "clientes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LastName", "Name" },
                values: new object[] { "Cliente Apellido 3", "Cliente Nombre 3" });

            migrationBuilder.UpdateData(
                table: "clientes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "LastName", "Name" },
                values: new object[] { "Cliente Apellido 4", "Cliente Nombre 4" });

            migrationBuilder.UpdateData(
                table: "clientes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "LastName", "Name" },
                values: new object[] { "Cliente Apellido 5", "Cliente Nombre 5" });

            migrationBuilder.UpdateData(
                table: "clientes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "LastName", "Name" },
                values: new object[] { "Cliente Apellido 6", "Cliente Nombre 6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "clientes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastName", "Name" },
                values: new object[] { "Lista 1", "Lista 1" });

            migrationBuilder.UpdateData(
                table: "clientes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastName", "Name" },
                values: new object[] { "Lista 2", "Lista 2" });

            migrationBuilder.UpdateData(
                table: "clientes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LastName", "Name" },
                values: new object[] { "Lista 3", "Lista 3" });

            migrationBuilder.UpdateData(
                table: "clientes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "LastName", "Name" },
                values: new object[] { "Lista 4", "Lista 4" });

            migrationBuilder.UpdateData(
                table: "clientes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "LastName", "Name" },
                values: new object[] { "Lista 5", "Lista 5" });

            migrationBuilder.UpdateData(
                table: "clientes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "LastName", "Name" },
                values: new object[] { "Lista 6", "Lista 6" });
        }
    }
}
