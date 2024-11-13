using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TypesfRelationships.Migrations
{
    /// <inheritdoc />
    public partial class create_resintents_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HouseModelResidentModel_ResidentModel_ResidentsId",
                table: "HouseModelResidentModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResidentModel",
                table: "ResidentModel");

            migrationBuilder.RenameTable(
                name: "ResidentModel",
                newName: "Residents");

            migrationBuilder.RenameColumn(
                name: "street",
                table: "Addresses",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "state",
                table: "Addresses",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Addresses",
                newName: "City");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Residents",
                table: "Residents",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HouseModelResidentModel_Residents_ResidentsId",
                table: "HouseModelResidentModel",
                column: "ResidentsId",
                principalTable: "Residents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HouseModelResidentModel_Residents_ResidentsId",
                table: "HouseModelResidentModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Residents",
                table: "Residents");

            migrationBuilder.RenameTable(
                name: "Residents",
                newName: "ResidentModel");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Addresses",
                newName: "street");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Addresses",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Addresses",
                newName: "city");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResidentModel",
                table: "ResidentModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HouseModelResidentModel_ResidentModel_ResidentsId",
                table: "HouseModelResidentModel",
                column: "ResidentsId",
                principalTable: "ResidentModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
