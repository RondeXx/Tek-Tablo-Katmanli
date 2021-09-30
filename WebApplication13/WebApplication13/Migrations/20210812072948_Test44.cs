using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication13.Migrations
{
    public partial class Test44 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Birimis",
                columns: table => new
                {
                    BirimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirimAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birimis", x => x.BirimID);
                });

            migrationBuilder.CreateTable(
                name: "Personelis",
                columns: table => new
                {
                    PersonelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Şehir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirimID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personelis", x => x.PersonelID);
                    table.ForeignKey(
                        name: "FK_Personelis_Birimis_BirimID",
                        column: x => x.BirimID,
                        principalTable: "Birimis",
                        principalColumn: "BirimID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personelis_BirimID",
                table: "Personelis",
                column: "BirimID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personelis");

            migrationBuilder.DropTable(
                name: "Birimis");
        }
    }
}
