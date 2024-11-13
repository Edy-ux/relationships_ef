using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TypesfRelationships.Migrations
{
    /// <inheritdoc />
    public partial class createTableResidentAndRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ResidentModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResidentModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseModelResidentModel",
                columns: table => new
                {
                    HouseId = table.Column<int>(type: "int", nullable: false),
                    ResidentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseModelResidentModel", x => new { x.HouseId, x.ResidentsId });
                    table.ForeignKey(
                        name: "FK_HouseModelResidentModel_Houses_HouseId",
                        column: x => x.HouseId,
                        principalTable: "Houses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HouseModelResidentModel_ResidentModel_ResidentsId",
                        column: x => x.ResidentsId,
                        principalTable: "ResidentModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HouseModelResidentModel_ResidentsId",
                table: "HouseModelResidentModel",
                column: "ResidentsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HouseModelResidentModel");

            migrationBuilder.DropTable(
                name: "ResidentModel");
        }
    }
}
