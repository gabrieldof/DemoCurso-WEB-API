using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Musicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musicos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Musicos",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Gustavo Cerati" },
                    { 2, "Indio Solari" },
                    { 3, "Miranda" },
                    { 4, "Charly García" },
                    { 5, "Divididos" },
                    { 6, "Mercedes Sosa" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Musicos");
        }
    }
}
