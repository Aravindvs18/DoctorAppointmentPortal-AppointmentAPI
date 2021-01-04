using Microsoft.EntityFrameworkCore.Migrations;

namespace AppointmentAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppointmentDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PatientAge = table.Column<string>(type: "nvarchar(3)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PatientNumber = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    SelectDoctor = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    SelectDate = table.Column<string>(type: "nvarchar(8)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentDetails", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentDetails");
        }
    }
}
