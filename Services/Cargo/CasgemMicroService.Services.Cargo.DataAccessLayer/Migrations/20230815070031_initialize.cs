using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasgemMicroService.Services.Cargo.DataAccessLayer.Migrations
{
    public partial class initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CargoState",
                columns: table => new
                {
                    CargoStateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoState", x => x.CargoStateID);
                });

            migrationBuilder.CreateTable(
                name: "CargoDetail",
                columns: table => new
                {
                    CargoDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderingID = table.Column<int>(type: "int", nullable: false),
                    CargoStateID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoDetail", x => x.CargoDetailID);
                    table.ForeignKey(
                        name: "FK_CargoDetail_CargoState_CargoStateID",
                        column: x => x.CargoStateID,
                        principalTable: "CargoState",
                        principalColumn: "CargoStateID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CargoDetail_CargoStateID",
                table: "CargoDetail",
                column: "CargoStateID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CargoDetail");

            migrationBuilder.DropTable(
                name: "CargoState");
        }
    }
}
