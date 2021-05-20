using Microsoft.EntityFrameworkCore.Migrations;

namespace Smart_city.Migrations
{
    public partial class Smart_cityDbmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pubele",
                columns: table => new
                {
                    PubelaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PubelaNume = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pubele", x => x.PubelaId);
                });

            migrationBuilder.CreateTable(
                name: "Sector",
                columns: table => new
                {
                    SectorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectorName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sector", x => x.SectorId);
                });

            migrationBuilder.CreateTable(
                name: "zone_sector",
                columns: table => new
                {
                    ZonaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZonaNume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SectorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zone_sector", x => x.ZonaId);
                    table.ForeignKey(
                        name: "FK_zone_sector_Sector_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sector",
                        principalColumn: "SectorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "raport_teren",
                columns: table => new
                {
                    RaportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StareIncarcare = table.Column<int>(type: "int", nullable: false),
                    ZonaId = table.Column<int>(type: "int", nullable: false),
                    PubelaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_raport_teren", x => x.RaportId);
                    table.ForeignKey(
                        name: "FK_raport_teren_Pubele_PubelaId",
                        column: x => x.PubelaId,
                        principalTable: "Pubele",
                        principalColumn: "PubelaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_raport_teren_zone_sector_ZonaId",
                        column: x => x.ZonaId,
                        principalTable: "zone_sector",
                        principalColumn: "ZonaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_raport_teren_PubelaId",
                table: "raport_teren",
                column: "PubelaId");

            migrationBuilder.CreateIndex(
                name: "IX_raport_teren_ZonaId",
                table: "raport_teren",
                column: "ZonaId");

            migrationBuilder.CreateIndex(
                name: "IX_zone_sector_SectorId",
                table: "zone_sector",
                column: "SectorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "raport_teren");

            migrationBuilder.DropTable(
                name: "Pubele");

            migrationBuilder.DropTable(
                name: "zone_sector");

            migrationBuilder.DropTable(
                name: "Sector");
        }
    }
}
