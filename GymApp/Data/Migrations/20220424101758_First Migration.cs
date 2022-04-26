using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymApp.Data.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "clientes",
                columns: new[] { "Id", "LastName", "Name" },
                values: new object[] { 1, "Lista 1", "Lista 1" });

            migrationBuilder.InsertData(
                table: "clientes",
                columns: new[] { "Id", "LastName", "Name" },
                values: new object[] { 2, "Lista 2", "Lista 2" });

            migrationBuilder.InsertData(
                table: "clientes",
                columns: new[] { "Id", "LastName", "Name" },
                values: new object[] { 3, "Lista 3", "Lista 3" });

            migrationBuilder.InsertData(
                table: "clientes",
                columns: new[] { "Id", "LastName", "Name" },
                values: new object[] { 4, "Lista 4", "Lista 4" });

            migrationBuilder.InsertData(
                table: "clientes",
                columns: new[] { "Id", "LastName", "Name" },
                values: new object[] { 5, "Lista 5", "Lista 5" });

            migrationBuilder.InsertData(
                table: "clientes",
                columns: new[] { "Id", "LastName", "Name" },
                values: new object[] { 6, "Lista 6", "Lista 6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clientes");
        }
    }
}
