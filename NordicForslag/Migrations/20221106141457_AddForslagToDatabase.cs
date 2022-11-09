using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NordicForslag.Migrations
{
    public partial class AddForslagToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Forslags",
                columns: table => new
                {
                    Navn = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tittel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Forbedringsforslag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Årsak = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mål = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Løsning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatoRegistrert = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forslags", x => x.Navn);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Forslags");
        }
    }
}
